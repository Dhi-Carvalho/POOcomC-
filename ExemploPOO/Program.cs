using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      //Exemplo de Abstração
      Pessoa p1 = new Pessoa();

      p1.Nome = "Bob";
      p1.Idade = 20;

      p1.Apresentar();

      //Exemplo de Encapsulamento
      // Valores válidos
      Retangulo r = new Retangulo();
      r.DefinirMedidas(30, 30);
      System.Console.WriteLine($"Área do retângulo: {r.ObterArea()}");

      // Valores inválidos
      Retangulo r2 = new Retangulo();
      r2.DefinirMedidas(0, 0);
      System.Console.WriteLine($"Área do retângulo: {r2.ObterArea()}");

      //Exemplos de Herança
      //Classe Aluno herdando de Pessoa
      Aluno p3 = new Aluno();
      p3.Nome = "Diogo";
      p3.Idade = 36;
      p3.Nota = 10;

      p3.Apresentar();
      System.Console.WriteLine($"Minha nota foi: {p3.Nota}");

      //Classe Professor herdando de Pessoa
      Professor p4 = new Professor();
      p4.Nome = "Ismael";
      p4.Idade = 68;
      p4.Salario = 1200.00;

      p4.Apresentar();
      System.Console.WriteLine($"Meu salário é R$ {p4.Salario}");

      //Exemplos de Polimorfismo
      //Polimorfismo em tempo de execução
      Aluno p5 = new Aluno();
      p5.Nome = "Diogo";
      p5.Idade = 36;
      p5.Nota = 10;

      p5.Apresentar();

      Professor p6 = new Professor();
      p6.Nome = "Ismael";
      p6.Idade = 68;
      p6.Salario = 1200.00;

      p6.Apresentar();

      //Polimorfismo em tempo de compilação
      Calculadora calc = new Calculadora();
      System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(5, 10));
      System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(6, 10, 5));

      //Exemplo Classes Abstartas
      Corrente c = new Corrente();
      c.Creditar(100);
      c.ExibirSaldo();
    }
  }
}