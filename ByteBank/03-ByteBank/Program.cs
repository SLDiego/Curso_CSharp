using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoGabriel = new ContaCorrente();
            contaDoGabriel.titular = "Gabriel";
            contaDoGabriel.agencia = 863;
            contaDoGabriel.numero = 863452;

            ContaCorrente contaDoGabriel2 = new ContaCorrente();
            contaDoGabriel2.titular = "Gabriel";
            contaDoGabriel2.agencia = 863;
            contaDoGabriel2.numero = 863452;

            //Referencia a ponta para um Objeto na memoria do PC
            Console.WriteLine("Igualdade do tipo de referencia " + (contaDoGabriel == contaDoGabriel2));

            Console.ReadLine();


        }

    }
}
