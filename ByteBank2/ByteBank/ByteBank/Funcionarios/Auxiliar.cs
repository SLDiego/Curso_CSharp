using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            Console.WriteLine("Auxiliar");
        }


        public override void AumentaSalario()
        {
            Salario *= 1.10;

        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }


    }



}
