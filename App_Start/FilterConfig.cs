﻿using System.Web;
using System.Web.Mvc;

namespace Tuan4_NguyenNgocThanh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
