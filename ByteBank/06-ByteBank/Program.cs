using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            //Definir Set
            conta.SetSaldo(-10);

            //Obter Get
            Console.WriteLine(conta.GetSaldo());


            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "433.4333.433-43";
            cliente.Profissao = "Pedreiro";

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();


        }
    }
}
