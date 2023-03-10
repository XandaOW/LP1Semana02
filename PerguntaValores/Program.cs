using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira altura:");
        
            int a = int.Parse( Console.ReadLine());
            Console.WriteLine("insira raio:");
            int r = int.Parse( Console.ReadLine());
            double pi = Math.PI;
            double V = pi * Math.Pow(r,2) * a;
            double Sa = 2*pi*r*(r+a);



            Console.WriteLine("The Volume is:" + V);
            Console.WriteLine("The Area is:" + Sa);
        }
    }
}
