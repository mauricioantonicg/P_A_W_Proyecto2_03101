﻿using System.Web;
using System.Web.Mvc;

namespace CP_Control_Aviones
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
