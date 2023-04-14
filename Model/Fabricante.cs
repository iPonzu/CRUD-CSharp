using System;

namespace Model{
    public class Fabricante
    {
        public int id_Fabricante{ get; set; }
        public string nome{ get; set; }
        public int idProduto {get;set;}

        public static List<Fabricante> Fabricantes { get; set; } = new List<Fabricante>();

        public Fabricante(
            int Id_Fabricante,
            string Nome,
            int IdProduto
        ){
            Id_Fabricante = id_Fabricante;
            Nome = nome;
            IdProduto = idProduto;


            Fabricantes.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {id_Fabricante}, Nome: {nome}, Id do Produto: {idProduto}";
        }

        public static void AlterarFabricante(int id_Fabricante, string nome, int idProduto){
            Fabricante Fabricante = BuscarFabricante(id_Fabricante);
            Fabricante.id_Fabricante = id_Fabricante;
            Fabricante.nome = nome;
            Fabricante.idProduto = idProduto;
        }

        public static void ExcluirFabricante(int id_Fabricante){
            Fabricante Fabricante = BuscarFabricante(id_Fabricante);
            Fabricantes.Remove(Fabricante);
        }

        public static Fabricante BuscarFabricante(int id_Fabricante){
            Fabricante? Fabricante = Fabricantes.Find(c=> c.id_Fabricante == id_Fabricante);
            if(Fabricante == null){
                throw new Exception("Fabricante não encontrado!");
            }
            return Fabricante;
        }
    }
}