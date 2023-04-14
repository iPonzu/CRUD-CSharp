using System;
using System.Data.SqlClient;

public abstract class DAO
{
    private static SqlConnection connection;

    public static SqlConnection CreateConnection()
    {
        try
        {
            string connectionString = @"jdbc:mysql://localhost:3306/crudcs;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public static void CloseConnection()
    {
        try
        {
            connection.Close();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
