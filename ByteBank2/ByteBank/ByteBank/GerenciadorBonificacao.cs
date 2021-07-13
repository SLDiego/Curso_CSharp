using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        //Regitrar o tota de bonificação
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();

        }



        //Método que retorna a bonificação Total 
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
