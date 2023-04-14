using System;

namespace Model{
    public class Fabricante
    {
        public string id_Fabricante{ get; set; }
        public string nome{ get; set; }

        public static List<Fabricante> Fabricantes { get; set; } = new List<Fabricante>();

        public Fabricante(
            string Id_Fabricante,
            string Nome
        ){
            Id_Fabricante = id_Fabricante;
            Nome = nome;


            Fabricantes.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {id_Fabricante}, Nome: {nome}";
        }

        public static void AlterarFabricante(string id_Fabricante, string nome){
            Fabricante Fabricante = BuscarFabricante(id_Fabricante);
            Fabricante.id_Fabricante = id_Fabricante;
            Fabricante.nome = nome;
        }

        public static void ExcluirFabricante(string id_Fabricante){
            Fabricante Fabricante = BuscarFabricante(id_Fabricante);
            Fabricantes.Remove(Fabricante);
        }

        public static Fabricante BuscarFabricante(string id_Fabricante){
            Fabricante? Fabricante = Fabricantes.Find(c=> c.id_Fabricante == id_Fabricante);
            if(Fabricante == null){
                throw new Exception("Fabricante não encontrado!");
            }
            return Fabricante;
        }
    }
}