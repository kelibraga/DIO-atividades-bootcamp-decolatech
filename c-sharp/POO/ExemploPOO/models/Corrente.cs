namespace ExemploPOO.models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
        base.saldo = valor;
        }
    }
    
}