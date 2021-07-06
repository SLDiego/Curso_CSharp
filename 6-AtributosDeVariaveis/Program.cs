using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtributosDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 30;
            int idadeDiego = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeDiego);


            Console.WriteLine("A execução acabou. Tecle enter para finalizar");
            Console.ReadLine();


        }
    }
}
