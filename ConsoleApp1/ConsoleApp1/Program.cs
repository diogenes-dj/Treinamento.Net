// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Models;

Pessoa pessoa1 = new Pessoa("Diogenes",30);



pessoa1.Apresentar();

//usar datas
DateTime dataAtual = DateTime.Now.AddDays(5); //Adicionando 5 dias na data
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));