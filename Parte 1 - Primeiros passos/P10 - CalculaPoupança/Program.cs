﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___CalculaPoupança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto P10 - Calcula Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                // 0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0096;
                Console.WriteLine("Após " + contadorMes + "mês você terá o valor " + valorInvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }

            Console.WriteLine("Tecle enter para encerrar");
            Console.ReadLine();


        }
    }
}
