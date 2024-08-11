// See https://aka.ms/new-console-template for more information
using Aula01.Models;

string Apresentacao = "Bem-vindos a academia TakanoPezo";

string Nome = "Leostroindinha";

int Idade = 60;

double Altura = 1.65;

decimal Preco = 79.99M;

DateTime DataAtual = DateTime.Now;

if (Preco == 79.99M)
{
    Console.WriteLine(Apresentacao);
        Console.WriteLine($"Aqui está sua ficha para começar a treinar! \n Nome: {Nome} \n Idade: {Idade} \n Altura: {Altura.ToString("0.00")} \n Plano Concebido: {Preco} \n Horario Criação da Ficha {DataAtual.ToString("dd/MM/yyyy HH:mm")} \n Tenha um bom treino! ");
} else {
    Console.WriteLine("Valor Invalido!");
}




//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Carlinhos amante da dalva";
//pessoa1.litros = 100;
//pessoa1.Pessoinha();