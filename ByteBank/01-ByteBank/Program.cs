using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoGabriel = new ContaCorrente();

            contaDoGabriel.titular = "Gabriel";
            contaDoGabriel.agencia = 863;
            contaDoGabriel.numero = 863452;
            contaDoGabriel.saldo = 100;

            Console.WriteLine("Titular " + contaDoGabriel.titular);
            Console.WriteLine("Agencia " + contaDoGabriel.agencia);
            Console.WriteLine("Numero " + contaDoGabriel.numero);
            Console.WriteLine("Saldo " + contaDoGabriel.saldo);



            Console.ReadLine();
        }
    }
}
