Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace DashboardJSControl
    Public Class MvcApplication
        Inherits System.Web.HttpApplication

        Protected Sub Application_Start()
            AreaRegistration.RegisterAllAreas()
            RouteConfig.RegisterRoutes(RouteTable.Routes)
            RouteTable.Routes.MapDashboardRoute("api/dashboard")
            DashboardConfigurator.Default.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Dashboards"))
        End Sub
    End Class
End Namespace
