using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoão = 16;
            int quantidadepessoas = 2;

            if (idadeJoão >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entra");
            }
            else
            {
                if (quantidadepessoas >= 2)
                {
                    Console.WriteLine("Jão não é maior de 18 anos, mas está acompanhado.");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar.");
                }
            }

            Console.WriteLine("A execução acabou. Tecle enter para finalizar");
            Console.ReadLine();

        }
    }
}
