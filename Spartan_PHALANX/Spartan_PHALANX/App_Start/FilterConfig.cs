﻿using System.Web;
using System.Web.Mvc;

namespace Spartan_PHALANX
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}