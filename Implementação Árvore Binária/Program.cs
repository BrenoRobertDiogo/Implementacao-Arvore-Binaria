using System;
using Estruturas;

namespace Implementação_Árvore_Binária
{
    class Program
    {
        static void Main(string[] args)
        {
            No nopai = new No(10);
            Arvore arvore = new Arvore(nopai);
            No no1 = new No(11);
            arvore.InserirNo(no1, arvore.Pai);
            No encontrar = arvore.BuscaNo(new Dado(11), arvore.Pai);

            arvore.InserirNo(new No(9), arvore.Pai);
            arvore.InserirNo(new No(15), arvore.Pai);
            arvore.InserirNo(new No(14), arvore.Pai);
            arvore.InserirNo(new No(13), arvore.Pai);
            arvore.InserirNo(new No(16), arvore.Pai);

            encontrar = arvore.BuscaNo(new Dado(15), arvore.Pai);
            Console.WriteLine(encontrar);
        }
    }
}
