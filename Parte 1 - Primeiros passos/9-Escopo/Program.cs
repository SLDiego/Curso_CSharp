﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoão = 16;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João esta acompanhado!";
            }
            else
            {
                mensagemAdicional = "João não esta acompanhado!";
            }

            

            if (idadeJoão >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
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
