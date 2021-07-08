using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            
            //Acessando a função SACAR -> Colocar valor entre parenteses
            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine("Saldo: " + contaDoBruno.saldo);
            Console.WriteLine("Retorno da função -> " + resultadoSaque);

            contaDoBruno.Depositar(1500);

            Console.WriteLine("Saldo do Conta " + contaDoBruno.saldo);


            ContaCorrente contaDoGabriel = new ContaCorrente();
            contaDoGabriel.titular = "Gabriel";


            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriel: " + contaDoGabriel.saldo);

            contaDoBruno.Transferir(100, contaDoGabriel);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriel: " + contaDoGabriel.saldo);






            Console.ReadLine();
        }
    }
}
