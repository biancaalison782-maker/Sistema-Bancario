namespace SistemaBancarioOOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(1154, "pedro Gustavo", 10);
            ContaCorrente conta2 = new ContaCorrente(11500, "Natalia", 0);
            ContaUniversitaria conta3 = new ContaUniversitaria(100, "Bianca");

            conta3.Bonus(50);
            conta3.ExibirDadosUniversitario();



        }

       
    }
}
