using Grupo_1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1.Interface
{
    internal interface LivroRepository
    {
        void AdicionarLivro();
        void RemoverLivro(string titulo);
        void ListarLivros();
    }
}
