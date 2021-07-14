using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public Autenticavel(string cpf, double salario) 
            : base(cpf, salario)
        {
                    
        }

        
        //Autenticar Senha do SistemaInterno
        public bool Autenticar(String senha)
        {
            return Senha == senha;
        }


    }
}
