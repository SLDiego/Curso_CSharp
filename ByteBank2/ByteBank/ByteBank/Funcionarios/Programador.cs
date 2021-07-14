using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Programador : Funcionario
    {
        public Programador(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentaSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }



}
