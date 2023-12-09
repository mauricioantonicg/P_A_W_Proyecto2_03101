using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CP_Control_Aviones.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         return View();
      }

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

      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";

         return View();
      }
   }
}