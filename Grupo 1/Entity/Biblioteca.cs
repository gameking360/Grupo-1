using Grupo_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1.Entity
{
    internal class Biblioteca : LivroRepository
    {
        public List<ItemBiblioteca> Itens { get; private set; }

        public Biblioteca() {
            Itens = new List<ItemBiblioteca>();
        }

        public void AdicionarLivro()
        {
            Console.WriteLine("Título do livro");
            string titulo = Console.ReadLine();
            Console.WriteLine("Autor do livro");
            string autor = Console.ReadLine();
            Console.WriteLine("Editora ");
            string editora = Console.ReadLine();
            Console.WriteLine("Número de páginas");
            int paginas = int.Parse(Console.ReadLine());
            Console.WriteLine("Gênero");
            string genero = Console.ReadLine();
            Console.WriteLine("Data de lançamento (dd/MM/yyyy)");
            DateTime data = DateTime.Parse(Console.ReadLine());
          
            Livro item = new Livro(titulo, autor,editora, paginas,genero, data);

            Itens.Add(item);
        }

        public void ListarLivros()
        {
            foreach(ItemBiblioteca item in Itens)
            {
                Console.WriteLine($"Título: {item.Titulo}\nGenero: {item.Genero} \nAno de Lançamento: {item.Data_Lancamento} \nAutor: {item.Autor} \nDisponibilidade: {item.Status}");
            }
        }

        public void RemoverLivro(string titulo)
        {
            ItemBiblioteca item = (ItemBiblioteca) Itens.Find(a => a.Titulo.ToLower() == titulo.ToLower());
            if (item != null) {
                Itens.Remove(item);
                Console.WriteLine("Item removido com sucesso");
            }
            Console.WriteLine("Erro ao remover o livro");
        }

        public Livro SelecionarLivro(string titulo)
        {
            Livro livro = (Livro) Itens.Find(a => a.Titulo.ToLower() == titulo.ToLower());

            return livro;

        }
    }
}