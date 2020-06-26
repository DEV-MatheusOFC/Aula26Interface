using System;

namespace Aula_26___Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Seu carrinho:");
            Produto produto1 = new Produto(1, "PlayStation 4", 2599f);
            Produto produto2 = new Produto(2, "Iphone 11 Pro Max", 7057f);
            Produto produto3 = new Produto(3, "Computador - I7(9°g)", 5600f);
            Produto produto4 = new Produto(4, "Televisão 60pol", 3200f);

            Carrinho carrinho = new Carrinho();
            carrinho.Incluir(produto1);
            carrinho.Incluir(produto2);
            carrinho.Incluir(produto3);
            carrinho.Incluir(produto4);

            carrinho.Ler();
            carrinho.MostrarTotal();
        }
    }
}
