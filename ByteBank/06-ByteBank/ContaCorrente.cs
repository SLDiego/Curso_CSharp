
namespace _06_ByteBank
{

    public class ContaCorrente
    {


     //   private Cliente _titular;

       /* public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }
       */

        //Como não tem logica.. pode ser escrito dessa forma
        public Cliente Titular { get; set; }
            

        public int agencia;
        public int numero;
        //encaplsulamento
        private double _saldo = 100;


        //Getters and Setters
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
            
            



        //Definir Set
        public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            
            this._saldo = saldo;
            
        }
        //Obter Get
        public double GetSaldo()
        {
            return _saldo;
        }



        //a Função tem que estar com a primeira letra Maiscula.
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        //Void não retorna nada
        public void Depositar(double valor)
        {
            this._saldo += valor;

        }

        //função depositar
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }


            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }


}
