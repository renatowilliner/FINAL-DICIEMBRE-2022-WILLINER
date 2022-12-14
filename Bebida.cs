using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WILLINER
{
    public class Bebida:Liquido
    {
        private int Tipo { get; set; }

        public Bebida(int tipo)
        {
            Tipo = tipo;
        }
    }
}
