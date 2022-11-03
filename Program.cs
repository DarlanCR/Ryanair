using System;

namespace ryanair
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = new Person();
            pessoa1.Name = "Teste";

            Console.WriteLine(pessoa1.Name);
        }
    }
}
