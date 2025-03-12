using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cadastro_de_Alunos_1._0
{
    internal class Program
    {
        public string nome;
        public string email;
        public string telefone;
        public string curso;
        public string matricula;


        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Sistema de Cadastro de Alunos n/");
            Console.WriteLine("Digite o nome do aluno: ");

            Console.WriteLine("Digite o e-mail do aluno: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o telefone do aluno: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento do aluno: ");
            string dataNascimento = Console.ReadLine();
            Console.WriteLine("Digite o curso do aluno: ");
            string curso = Console.ReadLine();

        

            CadAlunos aluno1 = new CadAlunos("Rayssa", "raydu@ferreira", "11 994044863", "Programação", "109348715");
            CadAlunos aluno2 = new CadAlunos("Anna", "anna@christofoletti", "11 996632564", "Programação", "105464655");
            CadAlunos aluno3 = new CadAlunos("Guilherme", "guilherme@amaro", "11 954462564", "Programação", "106566548");
            CadAlunos aluno4 = new CadAlunos("Lucas", "lucas@goldi", "11 954462564", "Programação", "106566548");

            List<CadAlunos> CadastroAlunos = new List<CadAlunos>();

            CadastroAlunos.Add(aluno1);
            CadastroAlunos.Add(aluno2);
            CadastroAlunos.Add(aluno3);
            CadastroAlunos.Add(aluno4);


        }
    }
}
