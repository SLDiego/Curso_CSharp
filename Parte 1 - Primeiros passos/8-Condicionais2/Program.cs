using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 8 - Condicionais2");

            int idadeJoão = 18;
            int quantidadepessoas = 2;

            //bool guarda um valor verdadeiro ou falso
            bool acompanhado = quantidadepessoas >= 2;

            if (idadeJoão >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                
                Console.WriteLine("Não pode entrar.");
                
            }

            Console.WriteLine("A execução acabou. Tecle enter para finalizar");
            Console.ReadLine();
        }
    }
}
