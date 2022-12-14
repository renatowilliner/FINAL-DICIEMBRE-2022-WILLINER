using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WILLINER
{
    public class Receta
    {
        private List<Ingrediente> Ingredientes { get; set; }   
        private int Autor { get; set; }
        private string Nombre { get; set; } 
        private int Codigo { get; set; }    
        private DateTime FechaEliminacion { get; set; } 
        private int Tipo { get; set; }
        public Receta(List<Ingrediente> ingredientes,int autor, string nombre, int codigo, DateTime fechaEliminacion, int tipo)
        {
            Ingredientes = ingredientes;
            Autor = autor;
            Nombre = nombre;
            Codigo = codigo;
            FechaEliminacion = fechaEliminacion;
            Tipo = tipo;
        }


        public List<Ingrediente> ObtenerIngredientes()
        {
            return Ingredientes;
        }
        public string ObtenerNombre()
        {
            return Nombre;
        }
        public int ObtenerTipo()
        {
            return Tipo;
        }
        public int ObtenerAutor()
        {
            return Autor;
        }

        public int ObtenerCodigo()
        {
            return Codigo;
        }
    }
}
