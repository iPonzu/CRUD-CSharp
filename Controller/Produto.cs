namespace Controller{
    public class Produto{
        public static void CadastrarProduto(
            int id_Produto,
            int nome
        ){
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id_Produto);
            }
            catch (Exception e)
            {
                throw new Exception ("ID do produto inválido {e.Message}" );
            }
        }
    }
}