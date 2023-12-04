using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Entidad
{
   public class listaAvionDespAterrizaje
   {
      public int CCCCCDespAvion { get; set; }
      public string serieAvi { get; set; }
      public string nombrePilotoAvion { get; set; }
      public string nombreEncargadoAvion { get; set; }
      public bool estadoAvionDespOAterrizo { get; set; }
      public string detallesDespegueAvion { get; set; }
      public string fechaAtterizajeAvion { get; set; }
      public string horaAterrizajeAvion { get; set; }
      public bool avionPerdidoEnMision { get; set; }
      public bool avionRequiereRescate { get; set; }
      public bool avionPerdidasHumanas { get; set; }
      public string detallesAterrizajeAvion { get; set; }
   }
}
