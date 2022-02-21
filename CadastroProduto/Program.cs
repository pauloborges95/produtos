using System;
using System.Globalization;

namespace CadastroProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto p = new Produto();//
            
            Console.WriteLine("Insira os dados do produto:");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Console.WriteLine("quantidade");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);*/
            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: "+ p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos: ");
            int remove = int.Parse(Console.ReadLine());
            p.RemoverProdutos(remove);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ p);
                



        }
    }
}
