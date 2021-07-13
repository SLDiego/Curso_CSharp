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
        public string CPF { get; set; }
        public double Salario { get; set; }


        //Método que retorna a bonificação 
        // Virtual metodo pode ser subscrevido
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }




    }
}
