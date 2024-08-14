' This module is used to configure global filters for the application.
' Global filters are applied to all controllers and actions within the application.
Public Module FilterConfig
    ' This method is called to register global filters for the application.
    ' Filters are used to perform cross-cutting concerns such as error handling, authorization, etc.
    Public Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)

        ' Add a global filter for handling errors.
        ' The HandleErrorAttribute filter catches unhandled exceptions and displays a friendly error page.
        ' This filter helps to manage errors gracefully and provide a better user experience.
        filters.Add(New HandleErrorAttribute())

    End Sub
End Module