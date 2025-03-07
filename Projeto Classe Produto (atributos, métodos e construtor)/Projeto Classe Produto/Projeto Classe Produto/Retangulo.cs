using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Classe_Produto
{
    internal class Retangulo
    {
        public double Altura = 20;
        public double Largura = 10;


        public double GetArea()
        {
            return Altura * Largura;
        }
        

        public double GetPerimetro()
        {
            return 2 * (Altura + Largura);
        }

    }
}
