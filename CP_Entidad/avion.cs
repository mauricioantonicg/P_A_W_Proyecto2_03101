using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Entidad
{
   public class avion : tipoAvion
   {
      public int numAvion { get; set; }
      public string serieAvion { get; set; }
      public string nombreFantasiaAvion { get; set; }
      public int idTipoAvio { get; set; }
      public bool estadoAvionRetOActivo { get; set; }
   }
}
