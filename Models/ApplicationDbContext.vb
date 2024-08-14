Imports System.Data.Entity

' Represents the application's database context.
Public Class ApplicationDbContext
    Inherits DbContext

    ' DbSet for accessing and managing Product entities in the database.
    ' Represents a collection of all products in the database.
    Public Property Products As DbSet(Of Product)

    ' DbSet for accessing and managing Customer entities in the database.
    ' Represents a collection of all customers in the database.
    Public Property Customers As DbSet(Of Customer)

    ' Constructor to configure the context with a connection string.
    ' This will use the default connection string name "ApplicationDbContext" from the configuration file.
    Public Sub New()
        MyBase.New("name=ApplicationDbContext")
    End Sub
End Class
