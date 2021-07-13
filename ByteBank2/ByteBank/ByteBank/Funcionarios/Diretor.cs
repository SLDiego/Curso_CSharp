using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {

        //Método que retorna a bonificação 
        //sobrescreve o metodo do Funcionario
        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}
