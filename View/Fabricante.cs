namespace View 
{
    public class Fabricante
    {
        public static void CadastrarFabricante()
        {
            Console.WriteLine("Cadastrar Fabricante");
            Console.WriteLine("Digite o ID do Fabricante: ");
            string idFabricante = Console.ReadLine();
            Console.WriteLine("Digite o ID do usuário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o tipo do Fabricante: ");
          
            try{
                Controller.Fabricante.CadastrarFabricante(idFabricante, nome);
                Console.WriteLine("Fabricante cadastrado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao cadastrar o Fabricante: {e.Message}");
            }
        }

        public static void AlterarFabricante()
        {
            Console.WriteLine("Digite o ID do Fabricante: ");
            string idFabricante = Console.ReadLine();
            Console.WriteLine("Digite o ID do usuário: ");
            string user_id = Console.ReadLine();
            Console.WriteLine("Digite o tipo do Fabricante: ");
            string tipo = Console.ReadLine();
            try{
                Controller.Fabricante.AlterarFabricante(idFabricante, user_id, tipo);
                Console.WriteLine("Fabricante alterado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao alterar o Fabricante: {e.Message}");
            }
        }

        public static void ExcluirFabricante()
        {
            Console.WriteLine("Digite o ID do Fabricante: ");
            string idFabricante = Console.ReadLine();
            try{
                Controller.Fabricante.ExcluirFabricante(idFabricante);
                Console.WriteLine("Fabricante excluido com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao excluir o Fabricante: {e.Message}");
            }
        }

        public static void ListarFabricantes(){
            Console.WriteLine("Listar Perfis");
            foreach (Model.Fabricante Fabricante in Controller.Fabricante.ListarFabricantes()) {
                Console.WriteLine(Fabricante);
            }
        }
    }
}               