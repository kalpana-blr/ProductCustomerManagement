' This module is used to configure the routing for the application.
' Routing determines how incoming requests are mapped to controller actions.
Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        ' This method is called to register route configurations for the application.
        ' Routes define the URL patterns that the application will handle and the corresponding controllers and actions.

        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        )
    End Sub
End Module