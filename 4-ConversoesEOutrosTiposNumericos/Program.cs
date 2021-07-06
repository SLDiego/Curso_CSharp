using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario;
            salario = 1200.50;


            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variavel de 64 bits
            long a;
            a = 13000000000;
            Console.WriteLine("long " + a);

            // O int é uma variavel de 64 bits
            int b;
            b = 1300000000;
            Console.WriteLine("int " + b);

            // O short é uma variavel de 16 bits
            short quantidaDeProdutos;
            quantidaDeProdutos = 15000;
            Console.WriteLine("short " + quantidaDeProdutos);

            // Variaveis do tipo float no C# precisam colocar o "f" ao lado do seu valor
            float c;
            c = 1.80f;
            Console.WriteLine("float " + c);

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();

        }
    }
}
