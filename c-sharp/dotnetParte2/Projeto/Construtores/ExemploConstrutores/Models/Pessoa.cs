namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
       private readonly string nome = "Keli"; //modo somente leitura, so pode alterar aqui na inicialização ou no construtor. No mais poderá ser feita a leitura.
       private readonly string sobrenome;

        public Pessoa() //construtor vazio, sem parametro, retornando string vazia
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        } 

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}