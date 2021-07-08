using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e Textos");

            //Caracteres
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);

            //String 
            string titulo = @"Teste de String
                - linha 1
                - linha 2";

            Console.WriteLine(titulo);





            Console.WriteLine("A execução acabou. Tecle enter para finalizar");
            Console.ReadLine();
        }
    }
}
