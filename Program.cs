using System;

namespace App 
{
    public class Program{
        public static void Main(string[] args){

            Console.WriteLine("Verdureira");
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
                
                }

            }while(op != 0);
        }
    }
}