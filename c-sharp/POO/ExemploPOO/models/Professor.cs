using System;

namespace ExemploPOO.models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
        Console.WriteLine($"Olá meu nome é {Nome} eu sou um professor e ganho um salário de {Salario}");
        }
    }
}