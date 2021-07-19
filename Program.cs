using System;
using System.Collections.Generic;

namespace Backend_Rec5
{
    class Program
    {
        static List<string> Nomes = new List<string>();
        static void Main(string[] args)
        {
            int idade;
            string resposta;
            string respostaSim;

            do
            {
                Console.WriteLine($"Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade > 16)
                {
                    Console.WriteLine("Sua entrada é permitida.");
                    Cadastrar(nome);
                }

                else
                {
                    bool V = false;
                    do
                    {
                        Console.WriteLine("O menor de idade está acompanhado com os pais ou maior de 18 anos?");
                        resposta = Console.ReadLine().ToLower();

                        switch (resposta)
                        {
                            case "sim":
                                Console.WriteLine($"Sua entrada é permitida");
                                Cadastrar(nome);
                                V = true;
                                break;

                            case "não":
                                Console.WriteLine($"Sua entrada não é permitida");
                                V = true;
                                break;

                            default:
                                Console.WriteLine($"Opção inválida! Digite uma opção válida");

                                break;
                        }
                    } while (V == false);

                }

                Console.WriteLine($"Gostaria de cadastrar mais alguem?");
                respostaSim = Console.ReadLine().ToLower();

            } while (respostaSim == "sim");

            Console.WriteLine($"\nPessoas Cadastradas");

            ListarNomes();

        }

        static void ListarNomes()
        {
            foreach (var cadaNome in Nomes)
            {
                Console.WriteLine($"{cadaNome}");

            }
        }

        static bool Cadastrar(string nome){

            Nomes.Add(nome);

            return true;
        }            
        
    }
}
