using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //referencia para um "objeto" na memoria
            Cliente gabriel = new Cliente();
            gabriel.nome = "Gabriel";
            gabriel.profissao = "Desenvolvedor C#";
            gabriel.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriel;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

           //acesso ao mesmo item na memoria
            Console.WriteLine(gabriel.nome);
            Console.WriteLine(conta.titular.nome);


            //outra forma de atribuir =, criar objeto
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = new Cliente();
            conta1.titular.nome = "João";
            conta1.titular.cpf = "333.222.444-50";
            conta1.titular.profissao = "Musico";



            Console.WriteLine(conta1.titular.nome);



            Console.ReadLine();


        }
    }
}
