using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = null;
            Console.WriteLine("Digite um nome: ");
            x = Console.ReadLine();

            Nome(x);


        }

        public static void Nome(string tst)
        {
            foreach (var item in tst)
            {

                if (item != ' ') { Console.WriteLine($"Esse é um {item}"); }

            }
        }

    }


}

