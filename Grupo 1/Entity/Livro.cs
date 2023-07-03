using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1.Entity
{
    internal class Livro : ItemBiblioteca
    {
        public Livro(string titulo, string autor, string editora, int num_Paginas, string genero, DateTime lancamento) : base(titulo,autor,editora,num_Paginas,genero,lancamento) { }

        public override void Devolver(Usuario user)
        {
            Status = Enum.Status.Disponível;
            user.ItensEmprestados.Remove(new Emprestimo(this, user, DateTime.Now + TimeSpan.FromDays(7)));
        }

        public override void Emprestar(Usuario user)
        {
            if (Status == Enum.Status.Disponível)
            {
                user.ItensEmprestados.Add(new Emprestimo(this, user,DateTime.Now + TimeSpan.FromDays(7)));
            }
        }
    }
}
