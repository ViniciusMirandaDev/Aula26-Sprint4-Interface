using System;

namespace Aula26_Sprint4_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Cuphead", 24f);
            Produto p2 = new Produto(2, "Halo", 74f);
            Produto p3 = new Produto(3, "Call of Duty Black Ops II", 246f);
            Produto p4 = new Produto(4, "FIFA 2021", 300f);

            Carrinho carrinho = new Carrinho();
            carrinho.Adicionar(p1);
            carrinho.Adicionar(p2);
            carrinho.Adicionar(p3);
            carrinho.Adicionar(p4);

            carrinho.Ler();
            carrinho.MostrarTotal();
        }
    }
}
