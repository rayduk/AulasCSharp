namespace Conta_Corrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(1000, 123, "Ellie");

            Console.WriteLine(conta.Saldo);
            conta.Depositar(500);
            conta.Sacar(200);
        }
    }
}
