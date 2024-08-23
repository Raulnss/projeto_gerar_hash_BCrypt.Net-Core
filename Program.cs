using System;
using BCrypt.Net;

namespace BCryptNetCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Coloque a senha: ");
            string senha = Console.ReadLine();
            string hashSenha = BCrypt.Net.BCrypt.HashPassword(senha);
            Console.WriteLine($"Hash gerado: {hashSenha}");
            Console.ReadKey();
            Console.WriteLine("coloque a senha");
            string n1 = Console.ReadLine();
            if (BCrypt.Net.BCrypt.Verify(n1, hashSenha))
            {
                Console.WriteLine(" senha correta");
            }
            else
            {
                Console.WriteLine(" senha incorreta");
            }
            Console.ReadKey();
        }
    }
}
