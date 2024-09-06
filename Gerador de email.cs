using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criador_de_email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//inicio

                string nome, nome1, email, usobrenome;
                Console.WriteLine("Digite seu nome para ter seu email: ");
                nome = Console.ReadLine();
                nome1 = nome.Substring(0, nome.IndexOf(" "));
                int nomeint = nome.Length;
                usobrenome = nome.Substring(nome.LastIndexOf(" "), nomeint - nome.LastIndexOf(" "));
                email = nome1 + (".") + usobrenome + ("@unimes.br");
                email = email.Replace(" ", "");
                email = email.ToLower();
                Console.WriteLine("Seu novo email é: " + email);

                Console.ReadKey();

            }//FIM

        }
    }
}