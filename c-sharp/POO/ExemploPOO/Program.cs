using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "/home/keli/decolatech/DIO-atividades-bootcamp-decolatech/c-sharp/POO/ExemploPOO/trabalhandocomarquivos";
            var caminhoPathCombine = Path.Combine(caminho, "pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var listaString = new List<string> { "Linha 1", "Linha 2", " Linha 3"};
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", " Linha 6"};


            FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho); //lista o caminho dos diretorios
            //helper.ListarArquivosDiretorios(caminho); //lista os arquivos
            //helper.CriarDiretorio(caminhoPathCombine);
            //System.Console.WriteLine("Criando Diretorio: " + caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            helper.LerArquivo(caminhoArquivo);

        
        // //exemplo de interface
        // ICalculadora calc = new Calculadora();
        // System.Console.WriteLine(calc.Somar(10, 20));


        //    //exemplo de herança e metodo de classe abstrata
        //     Corrente c = new Corrente();
        //     c.Creditar(100);

        //     c.ExibirSaldo();
                
        //    //exemplo de plimorfidmo compilação
        //     Calculadora calc = new Calculadora();
        //     System.Console.WriteLine("Resultado da primeira soma: "+ calc.Somar(10,10));
        //     System.Console.WriteLine("Resultado da segunda soma: "+ calc.Somar(10,10,10));
        
        //  // Exemplo de herança e Polimorfidmo execução   
        //     Aluno p1 = new Aluno();
        //     p1.Nota = 10;
        //     p1.Nome = "Bob";
        //     p1.Idade = 20;
        //     p1.Documento = "1827366729";
        //     p1.Apresentar();

        //     Professor p2 = new Professor();
        //     p2.Salario = 2000;
        //     p2.Nome = "Leo";
        //     p2.Idade = 40;
        //     p2.Documento = "99847755";
        //     p2.Apresentar();
        

        //   //exemplo de encapsulamento usando classe privada
        //         //com valores validos
        // Retangulo r = new Retangulo();
        // r.DefinirMedidas(30, 30);
        // System.Console.WriteLine($"Área: {r.ObterArea()}");
        
        //         //com valores invalidos
        // Retangulo r2 = new Retangulo();
        // r2.DefinirMedidas(0, 0);
        // System.Console.WriteLine($"Àrea: {r2.ObterArea()}");
                     
        //exemplo sobre abstração
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();            
        }
    }
}
