using System.Web;
using System.Web.Mvc;

namespace PRACTICA_REPOSITORIO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
