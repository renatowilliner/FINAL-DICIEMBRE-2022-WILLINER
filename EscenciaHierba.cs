using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WILLINER
{
    public class EscenciaHierba:Ingrediente
    {
       private string Origen { get; set; }
       //CORRECCIÓN: SE DEFINIÓ EL ENUM PERO NO SE USÓ.
       private string TipoSabor { get; set; }

    public EscenciaHierba(string origen, string tipoSabor)
        {
            Origen = origen;
            TipoSabor = tipoSabor;
        }   

    }
}
