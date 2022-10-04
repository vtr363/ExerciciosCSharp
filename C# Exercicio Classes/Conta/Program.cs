using System;
using ContaLib;

namespace Conta
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.Write("\nEntre o número da conta: ");
            int nConta = int.Parse(System.Console.ReadLine());

            System.Console.Write("\nEntre o titular da conta: ");
            string nome = System.Console.ReadLine();

            System.Console.Write("\nHaverá deposito inicial (s/n)?");
            string resp = System.Console.ReadLine().ToUpper();
            
            ContaBanco conta = new ContaBanco(nConta, nome);

            if(resp == "S"){
                System.Console.Write("\nEntre o valor de depósito inicial: ");
                conta.Deposito(double.Parse(Console.ReadLine()));
            }

            System.Console.WriteLine("\nDados da conta: \n" + conta);

            System.Console.Write("\nEntre o valor para deposito:");
            conta.Deposito(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("\nDados da conta atualizados: \n" + conta);

            System.Console.Write("\nEntre o valor para saque:");
            conta.Saque(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("\nDados da conta atualizados: \n" + conta);

        }
	}
}