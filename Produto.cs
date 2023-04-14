using System;

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
        return 
    }
}