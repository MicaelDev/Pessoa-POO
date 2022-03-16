using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.Idade = int.Parse(Console.ReadLine());

            if (primeiraPessoa.Idade > segundaPessoa.Idade)
            {
                Console.WriteLine("Pessoa mais velha:" + primeiraPessoa.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha:" + segundaPessoa.Nome);
            }
        }
    }
}
