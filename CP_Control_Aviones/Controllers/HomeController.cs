using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
         var httpClient = new HttpClient();
         var resultado = await httpClient.GetStringAsync("https://localhost:44303/Home/pruebaConexion");

         return "";
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";

         return View();
      }
   }
}