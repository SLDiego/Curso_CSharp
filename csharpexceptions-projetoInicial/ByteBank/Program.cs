using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                ContaCorrente conta = new ContaCorrente(456, 4578420);
                ContaCorrente conta2 = new ContaCorrente(456, 4578478);
                
                conta2.Transferir(-10, conta);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
            }   
            
            catch(ArgumentException e)
            {
                Console.WriteLine("Argumento com problema: " + e.ParamName);

                Console.WriteLine("Ocorreu uma exceçao do tipo ArgumentException");
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsulficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Excessão do tipo SaldoInsulficienteException");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
                      
            
            Console.ReadLine();
        }
        /*
        static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }
            catch (NullReferenceException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
        }

        static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é" + resultado);
        }
        static int Dividir(int numero, int divisor)
        {
            try
            {

                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exececao com numero= " + numero + " e divisor igual= " + divisor);
                throw;
            }
        }
        */


    }


}
