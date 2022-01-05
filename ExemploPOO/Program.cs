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
    }
  }
}