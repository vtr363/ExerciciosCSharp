using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaLib
{
    public class ContaBanco
    {
        public int NConta { get; private set;}
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBanco (int nConta, string nome) {
            this.NConta = nConta;
            this.Nome = nome;
        }

        public ContaBanco (int nConta, string nome, double depositoInicial) : this(nConta, nome) {
            this.Deposito(depositoInicial);
        }

        public override string ToString()
        {
            return $"Conta {NConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2")}";
        }

        public void Deposito(double valor){
            this.Saldo += valor;
        }

        public void Saque(double valor){
            this.Saldo -= (valor+5);
        }
    }
}