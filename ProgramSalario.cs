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
            Console.WriteLine("Digite o seu salario:");
            double salario = double.Parse(Console.ReadLine());
            if (salario <1700)
            {
                double soma = salario + 300;
                Console.WriteLine("Seu novo salario é: "+soma);
            }
            else
            {
                double soma = salario + 200;
                Console.WriteLine("Seu novo salario é: " + soma);
            }
            Console.ReadKey();
            Console.Clear();
            Main(null);
            return;
        }
    }
}
