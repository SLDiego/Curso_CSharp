using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {

        //recebe função Autenticar() da classe Autenticavel
        public bool Logar(Autenticavel funcionario, string senha)
        {
            //recebe o valor da Funcao Auntenticar(verdadeiro ou falso)  
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;

            }

        }

    }
}
