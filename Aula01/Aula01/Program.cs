// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Rayssa ");
Console.Write("Ferreira\n");

//string nomeCompleto = "Rayssa Eduarda Ferreira";
string firstName = "Rayssa";
string lastName = "Ferreira";
string surName = "Eduarda";

Console.WriteLine("Meu nome completo é " + firstName + lastName + surName);

//int idade = 18;

Console.WriteLine($"Meu nome completo é {firstName} {surName} {lastName} e a minha idade é {idade}");


Console.WriteLine("Escreva o seu nome: ");

string nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}, boa noite!!!");

Console.ReadKey();