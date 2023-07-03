using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1.Entity
{
    internal class Usuario  
    {
        private string CPF;
        private string Nome;

        public List<Emprestimo> ItensEmprestados { get; set; }

        public Usuario(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
            ItensEmprestados = new List<Emprestimo>();
        }

        public string getCPF()
        {
            return this.CPF;
        }
        
        public void setCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public string getNome()
        {
            return this.Nome;
        }
        public void setNome(string nome)
        {
            this.Nome = nome;
        }
    }
}
