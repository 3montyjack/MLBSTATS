﻿using System.Web;
using System.Web.Mvc;

namespace MLB_Basseball_Stats
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
