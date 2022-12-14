using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using WILLINER;
using static WILLINER.Class1;

namespace WILLINER
{
    public class Class1
    {
        public enum Usuarios { Vip = 1, Comun = 2 }
        public enum Bebida { Vino = 1, Gin = 2, Wiskey = 3 }
        public enum LiquidoCocina { Aceite = 1, Salsa = 2, Vinagre = 3; }
        public enum Sabores { Salado = 1, Dulce = 1, Agridulce = 3 }
        public enum Paises { Argetnina = 1, Grecia = 2, Hungria = 3, Indonesia = 4, Mexico = 5, Rusia = 6, Espania = 7, Urugay = 8, Vietnnam = 9 }

        public enum RecetasVariedad { Cocina = 1, Postres = 2, Cocteles = 3 }

        List<Receta> Recetas = new List<Receta>();
        List<Usuario> Usuarioss = new List<Usuario>();

        public List<string> RecetaParticular(Receta receta)
        {
            List<string> Datos = new List<string>();
            string nombre = receta.ObtenerNombre();
            string autor = receta.ObtenerNombre();
            Datos.Add(nombre);
            Datos.Add(autor);
            if (receta.ObtenerTipo() == (int)RecetasVariedad.Cocina)
            {
                List<Ingrediente> IngredientesReceta = receta.ObtenerIngredientes();
                for (int i = 0; i < IngredientesReceta.Count; i++)
                {
                    if (i < 3)
                    {
                        Datos.Add(IngredientesReceta[i].ToString());
                    }
                    else
                        break;
                }
            }
            else if (receta.ObtenerTipo() == (int)RecetasVariedad.Postres)
            {
                Datos.Add(nombre);
                Datos.Add(autor);
            }
            else
            {
                List<Ingrediente> IngredientesReceta = receta.ObtenerIngredientes();
                for (int i = 0; i < IngredientesReceta.Count; i++)
                {
                    Datos.Add(IngredientesReceta[i].ToString());
                }

            }
            return Datos;
        }

        public void CargarUsuario(string contrasenia, int tipo, string nickname, int codigoreceta, string nickfav, string xx)
        {
            var random = new Random();
            int codigo = random.Next(1, 100);
            if ((int)Usuarios.Vip == tipo)
            {
                Usuario usuario = new Usuario(codigo, contrasenia, nickname, tipo, AgregarRecetaFav(codigoreceta), AgregarUsuarioFavorito(nickfav));
                Usuarioss.Add(usuario);

            }
            else if ((int)Usuarios.Comun == tipo)
            {
                Usuario usuario = new Usuario(codigo, contrasenia, nickname, tipo);
                Usuarioss.Add(usuario);
            }

        }
        public void AgregarRecetaFav(string nick, string contrasenia, int codigo)
        {
            if (Validacion(nick, contrasenia) == true)
            {
                int index = Recetas.FindIndex(x => x.ObtenerCodigo() == codigo);

            }



        }

        public void AgregarUsuarioFavorito(string nickfav)
        {
            int indice = Usuarioss.FindIndex(x => x.ObtenerNickName() == nickfav);
        }

        public void Filtro(string texto, Usuario usuario)
        {
            if (Validacion(usuario.ObtenerNickName(), usuario.ObtenerContrasenia()) == true) ;
            {
                List<Receta> Help = new List<Receta>();
                Help = Recetas.FindAll(x => x.ObtenerIngredientes().ToString() == texto.ToLower() || x.ObtenerNombre() == texto.ToLower()).ToList();
                if (usuario.ObtenerTipo() == (int)Usuarios.Vip)
                {
                    Help.OrderBy(x => x.ObtenerCodigo().ToString() == usuario.ObtenerRecetasFavs().ToString());
                }

            }

        }
        public bool Validacion(string nickname, string contrasenia)
        {
            Usuario Validar = Usuarioss.Find(x => x.ObtenerNickName() == nickname && x.ObtenerContrasenia() == contrasenia);
            if (Validar == null)
            {
                return false;

            }
            else return true;


        }
    }
}


/////TEORIA 
/*
 * El A esta mal cuando quiere escribir el valor dentro de la lista ya que el item se escribiria con tal solo Console.Writeline(item)
 * 
 * 
 * En el C para podes escribir todos los valores hay que hacerlo mediante un for o un foreach para acceder a la posicion de cada valoe
 * 
 * 
 * El D jamas se ejecutara porque es hasta que i sea 0 o = y ya lo es 
 * 
 * 2) Las expresiones lambda sirven para devolver elementos a partir de una condicion, ademas de que ahorran mucho codigo 
 * List<int> Enteros {1,4,6,7,9,10,12,20,40}
 * 
 * List<int>mayores = Entetos.FinAll(x=>x>8)
 * 
 * 3) Es un componente integral de Windows que admite la creación y ejecución de aplicaciones
 * 
 * 
 * 4) Se entiende como divir a nuestro problemas en pequeñas soluciones para realizar nuestro programa de una forma mas facil y ordenada
 * 
 * 
 * 5) La  sobrecarga de metodos se utiliza cuando queremos realizar un mismo metodo y tenemos parametros distintos , 
 * lo mismo pasa cuando queremos insanciar una clase que tiene mas o menos propiedades, Una sobreeescritura se trata de metodos de comparten algunas
 * cosas similiares pero su resultado es distinto ya que siempre habra que realizar algo mas propia de esa clase 
 * 
 * public int Suma (int numero1 , int numero2)
 * {
 *      return int suma = numero1+ numero2
 * }
 * public int Suma (long numero2, long numero1)
 * {
 *      return long suma= numero2+numero1
 * }
 
 */
