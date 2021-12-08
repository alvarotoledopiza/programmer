// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization; //Usando o Sytem.Globalization ele deixará habilitar a função CultureInfo, para trocar vírgula por ponto.

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            bool completo = false;
            char genero = 'F'; //É do tipo Char, então ele deverá estar entre aspas simples.
            char letra = '\u0041'; //posso também inserir o unicode da letra ou simbolo, colocando barra invertida.
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green"; 
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            decimal n9 = decimal.MaxValue;
            int a = 10;
            a+= 2; //Se eu quiser acrescentar qualquer valor a uma variável, é só eu inserir a variável += valor que eu quero


            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(n2.ToString("F2"));
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);  //imprimindo_com_placeholders
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //imprimindo_utilizando_interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            Console.WriteLine(a); 
        }
    }
}
