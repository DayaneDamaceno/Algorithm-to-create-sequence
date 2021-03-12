using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02_Sequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtInicial;

            do
            {
                Console.Write("Insira o texto inicial para sua sequencia: ");
                txtInicial = Console.ReadLine();

            } while (txtInicial == "");

            int numSequencias = ValidaInt("Insira a quantidade de repetições dessa sequencia: ");

            CriarSequencia(txtInicial, numSequencias);

            Console.ReadKey();
        }

        static void CriarSequencia(string txtInicial, int numSequencias)
        {
            string resposta = "";
            int qtdRepetição = 1;

            Console.WriteLine("\nSequencia:");

            for (int i = 0; i < numSequencias; i++)
            {
                for (int n = 0; n < txtInicial.Length; n++)
                {
                    if (n != txtInicial.Length - 1)
                    {
                        if (txtInicial[n] == txtInicial[n + 1])
                        {
                            qtdRepetição++;
                        }
                        else
                        {
                            resposta += $"{qtdRepetição}{txtInicial[n]}";
                            qtdRepetição = 1;
                        }
                    }
                    else
                    {
                        resposta += $"{qtdRepetição}{txtInicial[n]}";
                        qtdRepetição = 1;
                    }

                }

                Console.WriteLine(resposta);
                txtInicial = resposta;
                resposta = "";
            }

        }

        static int ValidaInt(string mensagem)
        {
            int valor = -1;
            do
            {
                try
                {
                    Console.Write(mensagem);
                    valor = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nPor favor digite apenas números, maiores que 0!!\n");

                }
            } while (valor < 0);

            return valor;
        }
    }
}
