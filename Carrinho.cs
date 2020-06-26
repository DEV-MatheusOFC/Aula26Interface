using System;
using System.Collections.Generic;

namespace Aula_26___Interfaces
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int _cod, Produto _produtoAlterado)
        {
            carrinho.Find(x => x.Codigo == _cod).Nome = _produtoAlterado.Nome;
            carrinho.Find(z => z.Codigo == _cod).Preco = _produtoAlterado.Preco;
        }

        public void Excluir(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Incluir(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Ler()
        {
            foreach (Produto item in carrinho)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
        }
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if(carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"Total do Carrinho: \nR${ValorTotal.ToString("n2")} ");
            }else{
                Console.WriteLine($"Seu carrinho ainda está vazio!");
            }
        }
    }
}