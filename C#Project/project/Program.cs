using System;
using ProjectLibrary;

namespace project
{
    class program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("digite espaçadamente: Nome Preço(ex: 1.99) Quantidade");
            string[] input = Console.ReadLine().Split(" ");
            Produto p = new Produto(input[0], double.Parse(input[1]), int.Parse(input[2]));
            
            System.Console.WriteLine(p);
        }   
    }
}