using System;

namespace Model{
public class Produto
{
    public int id_Produto {get;set;}
    public string nome_produto {get;set;}
    public int codProduto {get;set;}

    public static List<Produto> Produtos {get;set;} = new List<Produto>();

    public Produto(
        int Id_Produto,
        string Nome_produto,
        int CodProduto
    ){
        Id_Produto = id_Produto;
        Nome_produto = nome_produto;
        CodProduto = codProduto;

        Produtos.Add(this);
    }

    public override string ToString()
    {
        return $"Id do Produto: {id_Produto}, Nome do produto: {nome_produto}, Código do produto: {codProduto}";
    }

    public static void AlterarProduto(int id_Produto, string nome, int codProduto){
            Produto Produto = BuscarProduto(id_Produto);
            Produto.id_Produto = id_Produto;
            Produto.nome_produto = nome;
            Produto.codProduto = codProduto;
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