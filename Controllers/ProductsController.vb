Imports System.Data.Entity
Imports System.Net

Namespace Controllers

    ' This controller manages CRUD operations for Product entities.
    Public Class ProductsController
        Inherits System.Web.Mvc.Controller

        ' Instance of the database context used to access the database.
        Private db As New ApplicationDbContext

        ' GET: Products
        ' Retrieves and displays a list of all products.
        Function Index() As ActionResult
            ' Fetches all products from the database and passes them to the view.
            Return View(db.Products.ToList())
        End Function

        ' GET: Products/Details/5
        ' Retrieves and displays the details of a specific product identified by id.
        Function Details(ByVal id As Integer?) As ActionResult
            ' Checks if the id is provided. If not, returns a bad request status.
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            ' Finds the product by id. If not found, returns a 404 Not Found status.
            Dim product As Product = db.Products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If

            ' Returns the view displaying the product details.
            Return View(product)
        End Function

        ' GET: Products/Create
        ' Displays the form to create a new product.
        Function Create() As ActionResult
            ' Returns the view for creating a new product.
            Return View()
        End Function

        ' POST: Products/Create
        ' Handles the form submission to create a new product.
        ' Protects against overposting attacks by enabling specific properties for binding.

        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ProductID,Name,Category,Price,Stock,LaunchDate")> ByVal product As Product) As ActionResult
            ' Checks if the model state is valid.
            If ModelState.IsValid Then
                ' Checks for existing products with the same name.
                Dim existingProduct = db.Products.FirstOrDefault(Function(p) p.Name = product.Name)
                If existingProduct IsNot Nothing Then
                    ' Adds a model error if a product with the same name already exists.
                    ModelState.AddModelError("Name", "Product name already exists.")
                    Return View(product)
                End If

                ' Adds the new product to the database and saves changes.
                db.Products.Add(product)
                db.SaveChanges()

                ' Redirects to the index page after successful creation.
                Return RedirectToAction("Index")
            End If

            ' Returns the view with validation errors if the model state is invalid.
            Return View(product)
        End Function

        ' GET: Products/Edit/5
        ' Retrieves and displays the form to edit a specific product identified by id.
        Function Edit(ByVal id As Integer?) As ActionResult
            ' Checks if the id is provided. If not, returns a bad request status.
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            ' Finds the product by id. If not found, returns a 404 Not Found status.
            Dim product As Product = db.Products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If

            ' Handles the case where LaunchDate is not set, assigning a default value if necessary.
            If IsNothing(product.LaunchDate) OrElse product.LaunchDate = Date.MinValue Then
                ' Handle the case where LaunchDate is not set
                product.LaunchDate = DateTime.Now ' Or some default value
            End If

            ' Returns the view for editing the product details.
            Return View(product)
        End Function

        ' POST: Products/Edit/5
        ' Handles the form submission to update a specific product.
        ' Protects against overposting attacks by enabling specific properties for binding.

        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ProductID,Name,Category,Price,Stock,LaunchDate")> ByVal product As Product) As ActionResult
            ' Checks if the model state is valid.
            If ModelState.IsValid Then
                ' Checks for uniqueness of the product name among other products with different IDs.
                Dim existingProduct = db.Products.FirstOrDefault(Function(p) p.Name = product.Name AndAlso p.ProductID <> product.ProductID)
                If existingProduct IsNot Nothing Then
                    ' Adds a model error if a product with the same name exists but with a different ID.
                    ModelState.AddModelError("Name", "Product name already exists.")
                    Return View(product)
                End If

                ' Marks the product entity as modified and saves changes to the database.
                db.Entry(product).State = EntityState.Modified
                db.SaveChanges()
                ' Redirects to the index page after successful update.
                Return RedirectToAction("Index")
            End If

            ' Returns the view with validation errors if the model state is invalid.
            Return View(product)
        End Function

        ' GET: Products/Delete/5
        ' Retrieves and displays the confirmation view for deleting a specific product identified by id.
        Function Delete(ByVal id As Integer?) As ActionResult
            ' Checks if the id is provided. If not, returns a bad request status.
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            ' Finds the product by id. If not found, returns a 404 Not Found status.
            Dim product As Product = db.Products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If

            ' Returns the view for confirming the deletion of the product.
            Return View(product)
        End Function

        ' POST: Products/Delete/5
        ' Handles the form submission to delete a specific product.
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            ' Finds the product by id and removes it from the database.
            Dim product As Product = db.Products.Find(id)
            db.Products.Remove(product)
            db.SaveChanges()
            ' Redirects to the index page after successful deletion.
            Return RedirectToAction("Index")
        End Function
        ' Releases resources used by the controller.
        ' This method is called when the controller is disposed of.
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            ' Disposes of the database context if it is being disposed.
            If (disposing) Then
                db.Dispose()
            End If
            ' Calls the base class dispose method.
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
