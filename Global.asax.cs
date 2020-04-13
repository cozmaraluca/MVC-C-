using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using GrandSmartphoneStore.Models;


namespace GrandSmartphoneStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

     /*   public void ConfigureServices()
        {

            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                var host = sbc.Host(new Uri("amqp://qfrbvwnf:w_DFZNZRTdMs9UME20FrrIvX0GFsq_lL@termite.rmq.cloudamqp.com/qfrbvwnf"), h =>
                {
                    h.Username("qfrbvwnf");
                    h.Password("w_DFZNZRTdMs9UME20FrrIvX0GFsq_lL");
                });
            });

            bus.Start();

            var repository = new List<Clienti>();
            var service = new ReservationService(bus, repository);


        }*/


    }
}
