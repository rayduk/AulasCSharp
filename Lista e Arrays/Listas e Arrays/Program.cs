using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_e_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Array Listas Vetores

            /*string[] arrayFrutas = new string[3];
            arrayFrutas[0] = "Banana";
            arrayFrutas[1] = "Maçã";
            arrayFrutas[2] = "Pera";*/

            int[] numeros = new int[5];
            double[] notas = new double[50];
            string[] arrayFrutas = {"Banana", "Maça", "Pera"};

            Console.WriteLine(arrayFrutas[0]);  //imprime Banana


            List<string> listaFrutas = new List<string>();
            listaFrutas.Add("Banana");
            listaFrutas.Add("Maçã");
            listaFrutas.Add("Pera");


            /*each (string Fruta in listaFrutas) { 
                 Console.WriteLine(Fruta);
             }

             listaFrutas.forEach(Fruta => Console.WriteLine(Fruta));
             { Console.WriteLine(Fruta); }*/

            Aluno aluno1 = new Aluno("Rayssa", 109348715, "ADS","raydu@gmail.com", "11994044863");
            Aluno aluno2 = new Aluno("Anna", 105464655, "Relações Internacionais", "anna@christofoletti.com", "11995632445");
            Aluno aluno3 = new Aluno("Guilherme", 106566548, "Finanças", "guilherme@amaro.com", "11954462564");

            List<Aluno> listaAlunos = new List<Aluno>();

            listaAlunos.Add(aluno1);
            listaAlunos.Add(aluno2);
            listaAlunos.Add(aluno3);

            foreach (Aluno aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.nome}");
                Console.WriteLine($"Matrícula: {aluno.matricula}");
                Console.WriteLine($"Curso: {aluno.curso}");
                Console.WriteLine($"E-mail: {aluno.email}");
                Console.WriteLine($"Tel:. {aluno.telefone}");
                Console.WriteLine();
            }
        }
    }
}
