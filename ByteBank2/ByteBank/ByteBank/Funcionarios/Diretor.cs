using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        //Método Contrutor, pegando da base Funcionario
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando Diretor");
        }


        public override void AumentaSalario() 
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.15;

        }

        //Método que retorna a bonificação 
        //sobrescreve o metodo do Funcionario
        public override double GetBonificacao()
        {
            // base puxa GetBonificacao da classe funicionario 
            return Salario * 0.5;
        }
    }
}
