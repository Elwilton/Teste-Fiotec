using System;
using System.IO;
namespace TesteFiotec
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Directory.GetFiles(@"/Users/eltin/Downloads/Apoio Analista| Externo_palavras.txt");
            foreach (string i in path)
            {
                Console.WriteLine(i);
            }
        }
    }

}