using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancarioOOO
{
    public abstract class ContaBancaria
    {
        private int numero;
        private string titular;
        protected double saldo;

        protected ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            saldo = 0;
        }

        public int Numero { get => numero; protected set => numero = value; }
        public string Titular { get => titular; protected set => titular = value; }


        



        public void depositar (double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                Console.WriteLine($"Depósito de {valor} Realizado com sucesso");
            }
        }

        public virtual bool Sacar(double valor)
        {
            if(valor <= saldo)
            {
                this.saldo -= valor;
                Console.WriteLine($"Saque de {valor} Realizado com sucesso");
                return true;
            }
            Console.WriteLine("Saldo insuficiente");
            return false; 
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Conta: {Numero} | Titular: {titular} | Saldo: {saldo} ");
        }

        public void Tranferir(double valor, ContaBancaria contaDestino)
        {
            if (valor <= saldo)
            {
                this.saldo -= valor;
                contaDestino.depositar(valor);
               
            }
           
            
        }
    }


}
