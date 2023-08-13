namespace ExemploFundamentos.Models //posso dar o nome q eu quiser, mas q faça sentido, afinidade. organização
{
    public class Pessoa //Nome do arquivo ser o mesmo nome da classe
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        private string Nome { get; set; } //atributos da classe pessoa(nome e idade)
        private int Idade { get; set; }

        private DateTime? Agencia { get; set; }

        public void Apresentar()    //método ou função da classe pessoa(são as ações)
        {
            Console.WriteLine($"Olá! Meu nome é " +
            $"{Nome} e tenho {Idade} anos");

            /*se fosse um texto muito grande eu poderia quebrá-lo apenas visualmente e não no resultado do conteúdo usando o + $
            
            classe.método (parâmetro com argumentos) quebrar texto é contra barra n \n
            */

        }
    }
}