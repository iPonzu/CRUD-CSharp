namespace Controller;

public class Fabricante
{
    public static void CadastrarFabricante(string idFabricante, string nome) //
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(idFabricante);
        }catch(Exception){
            throw new Exception ("Id inválido");
        }
        Model.Fabricante Fabricante = new Model.Fabricante (idFabricante, nome);
    }   
    
    public static void AlterarFabricante(string idFabricante, string nome) 
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(idFabricante);
        }catch(Exception){
            throw new Exception ("Id inválido");
        }
        Model.Fabricante.AlterarFabricante(idFabricante, nome);

    }
    public static void ExcluirFabricante(string id)
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(id);
        }catch(Exception){
            throw new Exception ("Id inválido");
        }
        Model.Fabricante.ExcluirFabricante(id);
    }
    public static Model.Fabricante BuscarFabricante(string id)
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(id);
        }catch(Exception){
            throw new Exception ("Id inválido");
        }
        return Model.Fabricante.BuscarFabricante(id);
    }
    public static List<Model.Fabricante> ListarFabricantes()
    {
        return Model.Fabricante.Fabricantes;
    }

}