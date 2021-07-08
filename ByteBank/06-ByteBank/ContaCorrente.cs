
namespace _06_ByteBank
{

    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            
            this.saldo = saldo;
            
        }

        public double ObterSaldo()
        {
            return saldo;
        }



        //a Função tem que estar com a primeira letra Maiscula.
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        //Void não retorna nada
        public void Depositar(double valor)
        {
            this.saldo += valor;

        }

        //função depositar
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }


            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }


}
