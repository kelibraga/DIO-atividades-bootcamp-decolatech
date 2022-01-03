using System;

namespace ExemploPOO.models
{
    public class Diretor : Professor
    {
        public sealed override void Apresentar()
        {
        Console.WriteLine($"Diretor");
        }
    }
}