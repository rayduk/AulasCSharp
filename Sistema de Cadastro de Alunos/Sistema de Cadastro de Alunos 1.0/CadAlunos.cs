using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cadastro_de_Alunos_1._0
{

    internal class Alunos
    {
        public string nome;
        public string email;
        public string telefone;
        public string curso;
        public string matricula;

        public Alunos(string nome, string email, string telefone, string dataNascimento, string curso, string matricula)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
            this.curso = curso;
            this.matricula = matricula;
        }
    }
}
