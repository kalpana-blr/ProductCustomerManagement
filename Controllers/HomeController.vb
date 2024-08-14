Public Class HomeController
    Inherits System.Web.Mvc.Controller

    ' GET: Home/Index
    ' Retrieves and displays the home page, including lists of products and customers.
    Function Index() As ActionResult
        ' Creates a new instance of the database context.
        Dim db As New ApplicationDbContext()

        ' Fetches all products from the database and stores them in ViewBag for use in the view.
        ViewBag.Products = db.Products.ToList()

        ' Fetches all customers from the database and stores them in ViewBag for use in the view.
        ViewBag.Customers = db.Customers.ToList()

        ' Returns the view associated with the Index action.
        Return View()
    End Function

    ' GET: Home/About
    ' Displays the About page with application description.
    Function About() As ActionResult
        ' Sets a message in ViewData to be displayed in the About view.
        ViewData("Message") = "Product and Customer Management"

        ' Returns the view associated with the About action.
        Return View()
    End Function
    ' GET: Home/Contact
    ' Displays the Contact page with contact information.
    Function Contact() As ActionResult
        ' Sets a message in ViewData to be displayed in the Contact view.
        ViewData("Message") = "WithYouWithMe."

        ' Returns the view associated with the Contact action.
        Return View()
    End Function
End Class
