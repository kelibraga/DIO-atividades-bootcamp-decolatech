using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program 
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
          Matematica m = new Matematica(10, 20);
          m.Somar();
          
          
            // Operacao op = Calculadora.Somar;  //outra forma de chamar o delegate
            // Operacao op =new Operacao(Calculadora.Somar);
            // op.Invoke(10, 10);

            // const double pi = 3.14;  //exemplode constante, unico local onde é possivel incluir o valor ou alterar, somente na inicialização.
            // System.Console.WriteLine(pi);
           
            // Data data = new Data();
            // //data.SetMes(2);

            // data.Mes = 13;
            // //System.Console.WriteLine(data.Mes);

            // data.ApresentarMes(); g.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            //Pessoa p1 = new Pessoa("Keli", "Braga");
            //p1.Apresentar();

                        
        }
    }
}
