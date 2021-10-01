Imports System.Web.Mvc
Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports DevExpress.DataAccess.Web

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        RouteTable.Routes.MapDashboardRoute("api/dashboard", "DefaultDashboard")
        DashboardConfigurator.Default.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Dashboards"))
        DashboardConfigurator.Default.SetConnectionStringsProvider(New ConfigFileConnectionStringsProvider())
    End Sub
End Class
