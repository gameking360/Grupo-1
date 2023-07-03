using System;
using Grupo_1.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Grupo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            Console.WriteLine("Bem vindo ao sistema da biblioteca, vamos fazer um rápido cadastro.");
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu cpf:");
            string cpf = Console.ReadLine();
            Usuario usuario = new Usuario(cpf,nome);
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine($"Olá, {usuario.getNome()}! O que deseja fazer em nossa Biblioteca?");
                Console.WriteLine("|===============================|");
                Console.WriteLine("|   1- Cadastrar novo livro     |");
                Console.WriteLine("|   2- Remover um livro         |");
                Console.WriteLine("|   3- Pegar um livro           |");
                Console.WriteLine("|   4- Listar livros            |");
                Console.WriteLine("|   5- Devolver um livro        |");
                Console.WriteLine("|   6- Sair                     |");
                Console.WriteLine("|===============================|");
                switch (Console.ReadLine())
                {
                    case "1":
                        biblioteca.AdicionarLivro();
                        break;
                    case "2":
                        Console.WriteLine("Digite o título que deseja remover");
                        string livroRemover = Console.ReadLine();
                        biblioteca.RemoverLivro(livroRemover);
                        
                        break;
                    case "3":
                        Console.WriteLine("Digite o título do livro que queria fazer um emprésitmo");
                        biblioteca.ListarLivros();
                        
                        string livroEmprestimo = Console.ReadLine();
                        
                        usuario.ItensEmprestados.Add(new Emprestimo(biblioteca.SelecionarLivro(livroEmprestimo), usuario, DateTime.Now + TimeSpan.FromDays(7)));
                        Console.ReadKey();
                        break;
                    case "4": biblioteca.ListarLivros();
                        break;
                    case "5":
                        Console.WriteLine("Digite o título do livro que você deseja devolver");
                        string livroDevolver = Console.ReadLine();

                        Livro devolucao = biblioteca.SelecionarLivro(livroDevolver);
                        devolucao.Devolver(usuario);
                        
                        break;
                    case "6": flag = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!\nPressione qualquer tecla e tente novamente");
                        break;
                }
            }


            Console.WriteLine("Saindo");
            for(int i = 3; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.ReadKey();

        }
    }
}
