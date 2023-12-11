using CP_Entidad;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI;

namespace CP_Control_Aviones.Controllers
{
   public class HomeController : Controller
   {
      List<avion> listaAviones;

      public ActionResult Index()
      {
         return View();
      }

      //Pagina con formulario para ingreso de aviones a la lista temporal
      public ActionResult IngresarNuevoAvion()
      {
         return View();
      }

      //Pagina con formulario para guardar de aviones a la base de datos
      public ActionResult GuardarNuevoAvion()
      {
         return View();
      }

      //Metodo de prueba de conexion con la api, se usa el async con el task para especificar que la consulta es asyncrona
      //de lo contrario la peticio sera sincronica 
      public async Task<string> probarConexionConApi()
      {

         //Consultar api con get

         //String con la url de la api
         //string urlGet = "https://localhost:44303/Home/pruebaConexion";

         ////Variable de http para la conexion 
         //var clienteHttp = new HttpClient();

         ////Limpiar cabecera de la peticion ya que no se requiere token de autorizacion 
         //clienteHttp.DefaultRequestHeaders.Clear();

         ////Variable que almacena la respuesta de la api 
         //var respuesta = clienteHttp.GetAsync(urlGet).Result;

         ////Variable para leer la respuesta 
         //var leerRespuesta = respuesta.Content.ReadAsStringAsync().Result;

         ////Convertir la respuesta en Json 
         //dynamic jsonRespuesta = JObject.Parse(leerRespuesta);



         //Consultar api con post

         //String con la url de la api
         string urlPost = "https://localhost:44303/Home/pruebaConexionPost";

         //Variable de http para la conexion 
         var clienteHttp = new HttpClient();

         //Limpiar cabecera de la peticion ya que no se requiere token de autorizacion 
         clienteHttp.DefaultRequestHeaders.Clear();

         //Parametros que llevara la peticion 
         string parametros = "{ 'prueba': '1', 'prueba2': '0' }";

         //Convertir los parametros a Json
         dynamic jsonParametros = JObject.Parse(parametros);

         //Agregar el contenido o parametros a la peticion 
         var contenidoHttp = new StringContent(Convert.ToString(jsonParametros), Encoding.UTF8, "application/json");

         //Variable que almacena la respuesta de la api 
         var respuesta = clienteHttp.PostAsync(urlPost, contenidoHttp).Result;

         //Variable para leer la respuesta 
         var leerRespuesta = respuesta.Content.ReadAsStringAsync().Result;

         //Convertir la respuesta en Json 
         dynamic jsonRespuesta = JObject.Parse(leerRespuesta);

         return "";
      }


      //Devolver la lista temporal de aviones  
      public JsonResult ListaTemporalAviones()
      {
         return Json(new { data = Session["listaAviones"] }, JsonRequestBehavior.AllowGet);
      }

      //Agregar un nuevo avion a la lista temporal 
      public JsonResult IngresarAvionAListaTemporal(avion datosAvion)
      {
         //Extraer la lista temporal de aviones de la sesion  
         listaAviones = (List<avion>) Session["listaAviones"];

         //Agregar los datos del nuevo avion a la sesion 
         if (listaAviones != null)
         {            
            listaAviones.Add(datosAvion);
         }
         else
         {
            listaAviones = new List<avion>();
            listaAviones.Add(datosAvion);
         }    

         //Agregar la lista de aviones nuevamente a la variable de sesion 
         Session["listaAviones"] = listaAviones;

         return Json(new { mensaje = "1" }, JsonRequestBehavior.AllowGet);
      }

      //Agregar un nuevo avion a la lista temporal 
      public JsonResult GuardarAvionBD(avion datosAvion)
      {
         string resultado = string.Empty;

         return Json(new { mensaje = "1" }, JsonRequestBehavior.AllowGet);
      }
   }
}