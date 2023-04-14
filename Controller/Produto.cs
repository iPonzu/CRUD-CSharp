namespace Controller;

public class Produto
{
    public static void CadastrarProduto(string id_Produto, string nome_produto)
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(id_Produto);
        }catch(Exception){
            throw new Exception ("Id inválido");
        }
        Model.Produto Produto = new Model.Produto (idConvert, nome_produto);
    }   
    
    public static void AlterarProduto(string id_Produto, string nome_produto) 
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(id_Produto);
        }catch(Exception){
            throw new Exception ("Id inválido");
        }
        Model.Produto.AlterarProduto(idConvert, nome_produto);

    }
    public static void ExcluirProduto(string id)
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(id);
        }catch(Exception){
            throw new Exception ("Id inválido");
        }
        Model.Produto.ExcluirProduto(idConvert);
    }
    public static Model.Produto BuscarProduto(string id)
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(id);
        }catch(Exception){
            throw new Exception ("Id inválido");
        }
        return Model.Produto.BuscarProduto(idConvert);
    }
    public static List<Model.Produto> ListarProdutos()
    {
        return Model.Produto.Produtos;
    }

}