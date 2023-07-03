using Grupo_1.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1.Entity
{
    abstract class ItemBiblioteca
    {
        public string Titulo { get; private set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Num_Paginas { get; set; }
        public string Genero { get; set; }
        public DateTime Data_Lancamento { get; set; }
        public Status Status { get; set; }

        public ItemBiblioteca() { }

        public ItemBiblioteca(string titulo, string autor, string editora, int num_Paginas, string genero, DateTime lancamento)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editora = editora;
            this.Num_Paginas = num_Paginas;
            this.Genero = genero;
            this.Data_Lancamento = lancamento;
            this.Status = (Enum.Status)1;
        }

        

        public abstract void Emprestar(Usuario user);

        public abstract void Devolver(Usuario user);

    }
}