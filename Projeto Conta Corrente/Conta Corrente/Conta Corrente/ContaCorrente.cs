using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Corrente
{
    internal class ContaCorrente
    {
        public int NumeroConta;
        public string Titular;
        public double Saldo;

        public ContaCorrente(double saldo, int numero, string titular) {

            Titular = titular;
            NumeroConta = numero;
            Saldo = saldo;
        }
        public void Depositar(double valorDeposito)
        {
             Saldo = Saldo + valorDeposito;

        Console.WriteLine($"Depósito efetuado com sucesso! Seu saldo atual é de R$ {Saldo}");
        }

        public void Sacar(double valorSaque)
        {
            if (Saldo >= valorSaque)
            {
                Saldo = Saldo - valorSaque;
                Console.WriteLine($"Saque efetuado com sucesso! Seu saldo atual é de R$ {Saldo}");
                return;
            }
            Console.WriteLine("Saldo insuficiente");
            
        }

    }

}

