using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancarioOOO
{
    internal class ContaCorrente : ContaBancaria
    {

        private double limiteChequeEspecial;
        public ContaCorrente(int numero, string titular, double limiteChequeEspecial) : base(numero, titular)
        {
        }
        public double LimiteChequeEspecial1
        {
            get => LimiteChequeEspecial1;
            private set => LimiteChequeEspecial1 = value;
        }
        public override bool Sacar(double valor)
        {
            double saldoDisponivel = saldo + limiteChequeEspecial;
            if (valor <= saldoDisponivel)
            {
                saldo -= valor;
                Console.WriteLine($"saque de R$ {valor} realizado com cheque especial");
                return true;
            }
            Console.WriteLine("saldo e limite isuficiente para saque na conta corrente.");
            return false;
        }
    }
}
