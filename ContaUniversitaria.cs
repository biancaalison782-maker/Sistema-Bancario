using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancarioOOO
{
    internal class ContaUniversitaria : ContaBancaria
    {
        public ContaUniversitaria(int numero, string titular) : base(numero, titular)
        {
        }
        public void Bonus(double valor)
        {
            if (valor > 0)
            {
                this.saldo = this.saldo = (valor * 1.05); //add 5% bonus 
                Console.WriteLine($"Bonus de 5% adicionado ao saldo da conta universitária.");

            }
            
            
        }
        public void ExibirDadosUniversitario()
        {
            Console.WriteLine($"Conta Universitária: {Numero} | Titular: {Titular} | Saldo: {saldo}");
        }


    }
}
