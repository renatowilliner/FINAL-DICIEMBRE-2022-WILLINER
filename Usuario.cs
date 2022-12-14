using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WILLINER
{
    public class Usuario
    {
        private int Codigo { get; set; }
        private string Nickname { get; set; }
        private string Contrasenia { get; set; }
        private int Tipo { get; set; }
        private List<Ingrediente> IngredientesFavs { get; set; }
        private List<Receta> RecetaFav { get; set; }
        private string UsuarioFavorito { get; set; }
        public Usuario(int codigo, string nickname, string contrasenia, int tipo)
        {
            Codigo = codigo;
            Nickname = nickname;
            Contrasenia = contrasenia;
            Tipo = tipo;


        }
        public Usuario(int codigo, string nickname, string contrasenia, int tipo, List<Ingrediente>ingredientesfavs ,List<Receta> recetafav, string favorito)
        {
            Codigo = codigo;
            Nickname = nickname;
            Contrasenia = contrasenia;
            Tipo = tipo;
            IngredientesFavs = ingredientesfavs;
            RecetaFav = recetafav;
            UsuarioFavorito = favorito;

        }

        public  string ObtenerNickName()
        {
            return Nickname ; 
        }

        public int ObtenerTipo()
        {
            return Tipo;
        }
        public List<Receta> ObtenerRecetasFavs()
        {
            return RecetaFav;

        }
        public string ObtenerContrasenia()
        {
            return Contrasenia;
        }
    }
}
