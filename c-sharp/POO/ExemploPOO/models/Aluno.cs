using System;

namespace ExemploPOO.models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
        Console.WriteLine($"Olá meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }
}