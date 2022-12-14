using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WILLINER
{
    public class Ingrediente
    {
        private int Codigo { get; set; }
        private string Nombre { get; set; }

        public Ingrediente(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }   
        public Ingrediente()
        {

        }
    }
    
}
