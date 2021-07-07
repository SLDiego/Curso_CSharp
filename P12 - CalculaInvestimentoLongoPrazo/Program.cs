using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12___CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto P12 - Calcula Investimento Longo Prazo");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int ano = 1; ano <= 5; ano++)
            {
                for (int mes = 1; mes <= 12; mes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao Termino do Investimento você tera " + valorInvestido);

            Console.ReadLine();





        }











    }
}
