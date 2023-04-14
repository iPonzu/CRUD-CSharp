using System;
using System.Data.SqlClient;


public class ConnectionDB {
    public static void Main(string[] args) {
        try {
            SqlConnection connec = DAO.CreateConnection();

            /* INSERT User */
            /* Usuario usuario = new Usuario("manezinho.ilha", "Manézinho da ilha", "347");
            SqlCommand stmt = new SqlCommand("INSERT INTO usuario (username, name, password) VALUES (@username, @name, @password)", connec);
            stmt.Parameters.AddWithValue("@username", usuario.Username);
            stmt.Parameters.AddWithValue("@name", usuario.Name);
            stmt.Parameters.AddWithValue("@password", usuario.Password);
            stmt.ExecuteNonQuery();*/

            /* SELECT ALL USERS */
            imprimirUsuarios(connec);

            /* DELETE id = 2 */
            SqlCommand stmt = new SqlCommand("DELETE FROM usuario WHERE id = @id", connec);
            stmt.Parameters.AddWithValue("@id", 2);
            stmt.ExecuteNonQuery();

            /* UPDATE id = 1 */
            stmt = new SqlCommand("UPDATE usuario SET username = @username, name = @name, password = @password WHERE id = @id", connec);
            stmt.Parameters.AddWithValue("@username", "jorge.pneu");
            stmt.Parameters.AddWithValue("@name", "Jorge dos pneus");
            stmt.Parameters.AddWithValue("@password", "654321");
            stmt.Parameters.AddWithValue("@id", 1);
            stmt.ExecuteNonQuery();

            imprimirUsuarios(connec);
        } catch (Exception e) {
            Console.WriteLine(e);
        }
    }

    private static void imprimirUsuarios(SqlConnection connec) {
        SqlDataReader rs = connec.CreateCommand().ExecuteReader("SELECT * FROM usuario");
        while (rs.Read()) {
            Usuario usuario2 = new Usuario(
                (int)rs["id"],
                rs["username"].ToString(),
                rs["name"].ToString(),
                rs["password"].ToString()
            );
            Console.WriteLine(usuario2);
            Console.WriteLine("===============================");
        }
        rs.Close();
    }
}
