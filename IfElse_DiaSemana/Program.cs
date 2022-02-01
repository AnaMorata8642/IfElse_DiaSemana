using System;

namespace IfElse_DiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaSemana = 0;

            Console.WriteLine("Digite o número de um dia da semana:");
            diaSemana = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (diaSemana == 1)
            {
                Console.WriteLine("O dia da semana correspondente é: Domingo");
                Console.WriteLine("*****************************************");
                Console.WriteLine("");
            }

            else if (diaSemana == 2)
            {
                Console.WriteLine("O dia da semana correspondente é: Segunda");
                Console.WriteLine("*****************************************");
                Console.WriteLine("");
            }

            else if (diaSemana == 3)
            {
                Console.WriteLine("O dia da semana correspondente é: Terça");
                Console.WriteLine("*****************************************");
                Console.WriteLine("");
            }

            else if (diaSemana == 4)
            {
                Console.WriteLine("O dia da semana correspondente é: Quarta");
                Console.WriteLine("*****************************************");
                Console.WriteLine("");
            }

            else if (diaSemana == 5)
            {
                Console.WriteLine("O dia da semana correspondente é: Quinta");
                Console.WriteLine("*****************************************");
                Console.WriteLine("");
            }

            else if (diaSemana == 6)
            {
                Console.WriteLine("O dia da semana correspondente é: Sexta");
                Console.WriteLine("*****************************************");
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("O dia da semana correspondente é: Sábado");
                Console.WriteLine("*****************************************");
            }
        }
    }
}
