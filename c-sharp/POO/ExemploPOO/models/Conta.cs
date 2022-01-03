namespace ExemploPOO.models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor); //método abstrato, é obrigado a ser subcrito para poder usar esta classe abstrata

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é : " + saldo);
        }
    }
}