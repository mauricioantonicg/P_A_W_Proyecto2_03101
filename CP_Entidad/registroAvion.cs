using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Entidad
{
   public class registroAvion
   {
      public int idOrdenRegistroAvion { get; set; }
      public string serieAvio { get; set; }
      public string nombreTecnicoRegistraAvion { get; set; }
      public string fechaRegistroAvion { get; set; }
      public string horaRegistroAvion { get; set; }
      public int consecutivoOrdenRegistroAvion { get; set; }
   }
}
