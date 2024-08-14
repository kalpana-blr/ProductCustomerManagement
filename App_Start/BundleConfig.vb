Imports System.Web.Optimization

' This module is used to configure and register script and style bundles for the application.
Public Module BundleConfig
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        ' This method is called to register the bundles for the application.
        ' The bundles help optimize loading times by grouping scripts and styles into single files.

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New Bundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/site.css"))
    End Sub
End Module

