using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CalculaPoupança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto P11 - Calcula Poupança");

            double valorInvestido = 1000;
            

            for (int i = 1; i <= 12; i++)
            {
                // 0.36% = 0.0036
                valorInvestido = valorInvestido * 1.0036;
                if (i < 2)
                {                    
                    Console.WriteLine("Após " + i + " mês você terá o valor " + valorInvestido);
                }
                else
                {
                    Console.WriteLine("Após " + i + " mêses você terá o valor " + valorInvestido);
                }

            }




            Console.WriteLine();
            Console.WriteLine("Tecle enter para encerrar");
            Console.ReadLine();

        }
    }
}
