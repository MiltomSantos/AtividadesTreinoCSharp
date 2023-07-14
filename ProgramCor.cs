using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade");
            int idade = int.Parse(Console.ReadLine());
            if(idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você ainda não tem idade suficiente");
                Console.ReadLine();
                Console.Clear();
                return;
                Main(null);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Idade permitida, você tem mais de 18 anos");
            Console.ReadKey();
        }
    }
}
