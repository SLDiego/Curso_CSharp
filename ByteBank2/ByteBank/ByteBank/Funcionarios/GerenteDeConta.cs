using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Herança GerenteDeConta - Autenticavel - Funcionario
    public class GerenteDeConta : Autenticavel
    {
        


        //Construtor Gerente de Contas
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {

            Console.WriteLine("Gerente de Conta");
        }




        public override void AumentaSalario()
        {
            Salario *= 1.05; 
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

    }
}
