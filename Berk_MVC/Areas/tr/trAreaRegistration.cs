using System.Web.Mvc;

namespace Berk_MVC.Areas.tr
{
    public class trAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "tr";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
             "trkategoridetay",
             "tr/{controller}/{id}/{id2}",
             new { controller = "KategoriDetay", action = "Index", id = UrlParameter.Optional, id2 = UrlParameter.Optional }
         );
            context.MapRoute(
               "trdetay",
               "tr/{controller}/{id}/{id2}",
               new { controller = "Detay", action = "Index", id = UrlParameter.Optional , id2=UrlParameter.Optional}
           );

            context.MapRoute(
                "tr_default",
                "tr/{controller}/{action}/{id}",
                new { controller = "Index" ,action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}