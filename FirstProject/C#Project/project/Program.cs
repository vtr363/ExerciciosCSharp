using System;
using System.Globalization;
using ProjectLibrary;

namespace project
{
    class program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Nome:");
            string Nome = Console.ReadLine();

            System.Console.Write("\nPreço(ex: 1.99):");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("\nQuantidade no estoque:");
            int Quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(Nome, Preco, Quantidade);
            
            System.Console.WriteLine("\nDados do produto:" + p);

            System.Console.WriteLine("\ndigite a quantidade de produtos a ser adicionada:");
            p.AdicionaProduto(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("\nDados atualizados: " + p);

            System.Console.Write("\nDigite o numero de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("\nDados atualizados: " + p);
        }
    }
}