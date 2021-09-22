using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using System.Web.Mvc;
using System.Web.Routing;

namespace DashboardJSControl {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RouteTable.Routes.MapDashboardRoute("api/dashboard");
            DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage("~/App_Data/Dashboards"));
        }
    }
}
