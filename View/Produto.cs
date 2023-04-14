namespace View 
{
    public class Produto
    {
        public static void CadastrarProduto()
        {
            Console.WriteLine("Cadastrar Produto");
            Console.WriteLine("Digite o ID do Produto: ");
            string id_Produto = Console.ReadLine();
            Console.WriteLine("Digite o nome do Produto: ");
            string nome = Console.ReadLine();
          
            try{
                Controller.Produto.CadastrarProduto(id_Produto, nome);
                Console.WriteLine("Produto cadastrado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao cadastrar o Produto: {e.Message}");
            }
        }

        public static void AlterarProduto()
        {
            Console.WriteLine("Digite o ID do Produto: ");
            string id_Produto = Console.ReadLine();
            Console.WriteLine("Digite o ID do usuário: ");
            string user_id = Console.ReadLine();
            Console.WriteLine("Digite o tipo do Produto: ");
            string tipo = Console.ReadLine();
            try{
                Controller.Produto.AlterarProduto(id_Produto, user_id, tipo);
                Console.WriteLine("Produto alterado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao alterar o Produto: {e.Message}");
            }
        }

        public static void ExcluirProduto()
        {
            Console.WriteLine("Digite o ID do produto: ");
            string id_Produto = Console.ReadLine();
            try{
                Controller.Produto.ExcluirProduto(id_Produto);
                Console.WriteLine("Produto excluido com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao excluir o Produto: {e.Message}");
            }
        }

        public static void ListarProdutos(){
            Console.WriteLine("Listar Perfis");
            foreach (Model.Produto Produto in Controller.Produto.ListarProdutos()) {
                Console.WriteLine(Produto);
            }
        }
    }
}               