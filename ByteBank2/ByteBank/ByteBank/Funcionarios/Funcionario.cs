using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
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


        public abstract void AumentaSalario();


        //Método que retorna a bonificação 
        // Virtual metodo pode ser subscrevido
        public abstract double GetBonificacao();




    }
}
