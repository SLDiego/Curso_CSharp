using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);

            

            Console.WriteLine(conta.Numero + " " + conta.Agencia);

            ContaCorrente contaDoGabriel = new ContaCorrente(867, 86777540);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            

            Console.ReadLine();

            
        }
    }
}
