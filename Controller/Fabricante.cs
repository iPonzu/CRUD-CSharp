namespace Controller
{
public class Fabricante
{
    public static void CadastrarFabricante(
        string idFabricante,
        int nome
    ){
        int idConvert = 0;
        try{
            idConvert = int.Parse(idFabricante);
        }catch(Exception e) {
            throw new Exception("ID inválido!");
        }
        Model.Fabricante Fabricante = new Model.Fabricante(idConvert, idFabricante, nome);
    }
    
    public static void AlterarFabricante(
        string idFabricante,
        int nome
    ){
        int idConvert = 0;
        try{
            idConvert = int.Parse(idFabricante);
        }catch(Exception) {
            throw new Exception("ID inválido!");
        }
        Model.Fabricante.AlterarFabricante(idConvert, idFabricante, nome);
    }
    
    public static void ExcluirFabricante(string idFabricante)
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(idFabricante);
        }catch(Exception) {
            throw new Exception("ID inválido!");
        }
        Model.Fabricante.ExcluirFabricante(idConvert);
    }
    
    public static Model.Fabricante BuscarFabricante(string idFabricante)
    {
        int idConvert = 0;
        try{
            idConvert = int.Parse(idFabricante);
        }catch(Exception) {
            throw new Exception("ID inválido!");
        }
        
        return Model.Fabricante.BuscarFabricante(idConvert);
    }
    
    public static List<Model.Fabricante> ListarFabricantes()
    {
        return Model.Fabricante.Fabricantes;
    }
}
}