using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DataAccess.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HtmlJavaScriptApp {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RouteTable.Routes.MapDashboardRoute("api/dashboard", "DefaultDashboard");
            DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage("~/App_Data/Dashboards"));
            DashboardConfigurator.Default.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
        }
    }
}
