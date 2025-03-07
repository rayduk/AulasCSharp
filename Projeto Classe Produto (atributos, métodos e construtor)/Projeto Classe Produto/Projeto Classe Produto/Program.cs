namespace Projeto_Classe_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(500, "Lápis", 2.50);
            Produto produto2 = new Produto(250, "Paçoca", 10.50);
            Produto produto3 = new Produto(221, "Chá Baer Matte", 7.99);

            /*Console.WriteLine(produto1.GetDetailProduct());
            Console.WriteLine(produto2.GetDetailProduct());
            Console.WriteLine(produto3.GetDetailProduct());*/


            Retangulo retangulo1 = new Retangulo();

            Console.WriteLine("A área do Retangulo1 é: " +retangulo1.GetArea());
            Console.WriteLine("O perimetro do Retangulo1 é: " +retangulo1.GetPerimetro());
        }
    }
}
