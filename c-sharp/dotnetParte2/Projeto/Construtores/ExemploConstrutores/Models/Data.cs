namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;        //metodo get set
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        
        public int Mes      //propriedade get set, esta forma é mais simples de usar o get set!
        {
            get
            {
                return this.mes;
            }
            set
            {
                if (value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;    
                }
            }
        }
        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mes invalido");
            }
        }


    }
}