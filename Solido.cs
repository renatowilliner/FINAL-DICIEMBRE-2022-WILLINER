using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WILLINER
{
    public class Solido:Ingrediente 
    {
        private int Gramos { get; set; }   
        public Solido(int gramos)
        {
            Gramos = gramos;
        }   
    }
}
