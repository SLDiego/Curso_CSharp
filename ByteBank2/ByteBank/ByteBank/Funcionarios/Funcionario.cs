using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public static int TotalFuncionario { get; private set; }
        //Método Contrutor , total de funcionarios
        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;

            TotalFuncionario++; 
        }

        public virtual void AumentaSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.1;

        }

        //Método que retorna a bonificação 
        // Virtual metodo pode ser subscrevido
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }




    }
}
