using System;
using System.Globalization; //Usando o Sytem.Globalization ele deixará habilitar a função CultureInfo, para trocar vírgula por ponto.

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos:\r\n{produto1}, cujo preço é {preco1}"); // \r\n para pular de linha
            Console.WriteLine($"{produto2}, cujo preço é {preco2}");
            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString(CultureInfo.InvariantCulture));



        }
    }
}
