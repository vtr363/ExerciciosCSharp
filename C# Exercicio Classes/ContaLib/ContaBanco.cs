using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaLib
{
    public class ContaBanco
    {
        public int NConta { get; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public ContaBanco (int nConta, string nome) {
            this.NConta = nConta;
            this.Nome = nome;
        }

        public ContaBanco (int nConta, string nome, double saldo) : this(nConta, nome) {
            this.Saldo = saldo;
        }

        public override string ToString()
        {
            return $"Conta {NConta}, Titular: {Nome}, Saldo: $ {Saldo}";
        }

        public void Deposito(double valor){
            this.Saldo += valor;
        }

        public void Saque(double valor){
            this.Saldo -= (valor+5);
        }
    }
}