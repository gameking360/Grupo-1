using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1.Entity
{
    internal class Emprestimo
    {
        
        public DateTime Data_emprestimo { get; set; }
        public DateTime Data_devolucao { get; set; }
        public Usuario Usuario { get ; set; }

        public Emprestimo (ItemBiblioteca item, Usuario usuario, DateTime data_devolucao)
        {            
            this.Data_emprestimo = DateTime.Now;
        }
        
    }
}
