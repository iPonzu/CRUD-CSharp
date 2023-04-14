using System;

namespace App 
{
    public class Program{
        
        public static void Main(string[] args){

            Console.WriteLine("Bem Vindo a FastFruits Verdureira");
            int op = 0;
            do{
                Console.WriteLine("===========================");
                Console.WriteLine("1 - Cadastrar Fabricante");
                Console.WriteLine("2 - Alterar Fabricante");
                Console.WriteLine("3 - Excluir Fabricante");
                Console.WriteLine("4 - Listar Fabricantes");
                Console.WriteLine("5 - Cadastrar Produto");
                Console.WriteLine("6 - Alterar Produto");
                Console.WriteLine("7 - Excluir Produto");
                Console.WriteLine("8 - Listar Produto");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("===========================");
                Console.WriteLine("Opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op){
                
                    case 1: 
                        View.Fabricante.CadastrarFabricante();
                        break;
                    case 2:
                        View.Fabricante.AlterarFabricante();
                        break;
                    case 3:
                        View.Fabricante.ExcluirFabricante();
                        break;
                    case 4:
                        View.Fabricante.ListarFabricantes();
                        break;
                    case 5:
                        View.Produto.CadastrarProduto();
                        break;
                    case 6: 
                        View.Produto.AlterarProduto();
                        break;
                    case 7:
                        View.Produto.ExcluirProduto();
                        break;
                    case 8:
                        View.Produto.ListarProdutos();
                        break;
                    case 0:
                        Console.WriteLine("Vazando...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            }while(op != 0);
        }
    }
}
