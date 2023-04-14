using System;

namespace Model{
public class Produto
{
        private int idConvert;

        public int id_Produto {get;set;}
    public string nome_produto {get;set;}
    public static List<Produto> Produtos {get;set;} = new List<Produto>();

    public Produto(
        int Id_Produto,
        string Nome_produto,
        int CodProduto
    ){
        Id_Produto = id_Produto;
        Nome_produto = nome_produto;

        Produtos.Add(this);
    }

        public Produto(int idConvert, string nome_produto)
        {
            this.idConvert = idConvert;
            this.nome_produto = nome_produto;
        }

        public override string ToString()
    {
        return $"Id do Produto: {id_Produto}, Nome do produto: {nome_produto}";
    }

    public static void AlterarProduto(int id_Produto, string nome){
            Produto Produto = BuscarProduto(id_Produto);
            Produto.id_Produto = id_Produto;
            Produto.nome_produto = nome;
        }

        public static void ExcluirProduto(int id_Produto){
            Produto Produto = BuscarProduto(id_Produto);
            Produtos.Remove(Produto);
        }

        public static Produto BuscarProduto(int id_Produto){
            Produto? Produto = Produtos.Find(c=> c.id_Produto == id_Produto);
            if(Produto == null){
                throw new Exception("Produto não encontrado!");
            }
            return Produto;
        }
    }
}    