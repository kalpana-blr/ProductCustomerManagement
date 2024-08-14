Imports System.Data.Entity
Imports System.Net

Namespace Controllers

    ' This controller handles CRUD operations for Customer entities.
    Public Class CustomersController
        Inherits System.Web.Mvc.Controller

        ' Instance of the database context for accessing the database.
        Private db As New ApplicationDbContext

        ' GET: Customers
        ' Retrieves and displays a list of all customers.
        Function Index() As ActionResult
            ' Fetches all customers from the database and passes them to the view.
            Return View(db.Customers.ToList())
        End Function

        ' GET: Customers/Details/5
        ' Retrieves and displays the details of a specific customer identified by id.
        Function Details(ByVal id As Integer?) As ActionResult
            ' Checks if the id is provided. If not, returns a bad request status.
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            ' Finds the customer by id. If not found, returns a 404 Not Found status.
            Dim customer As Customer = db.Customers.Find(id)
            If IsNothing(customer) Then
                Return HttpNotFound()
            End If

            ' Returns the customer details view.
            Return View(customer)
        End Function

        ' GET: Customers/Create
        ' Displays the form to create a new customer.
        Function Create() As ActionResult
            ' Returns the view for creating a new customer.
            Return View()
        End Function

        ' POST: Customers/Create
        ' Handles the form submission for creating a new customer.
        ' Protects against overposting attacks by binding only specific properties.

        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="CustomerID,Name,Email,RegistrationDate")> ByVal customer As Customer) As ActionResult
            ' Checks if the model state is valid.
            If ModelState.IsValid Then
                ' Checks for existing customers with the same name.
                Dim existingCustomerByName = db.Customers.FirstOrDefault(Function(c) c.Name = customer.Name)
                If existingCustomerByName IsNot Nothing Then
                    ModelState.AddModelError("Name", "Customer name already exists.")
                    Return View(customer)
                End If

                ' Checks for existing customers with the same email.
                Dim existingCustomerByEmail = db.Customers.FirstOrDefault(Function(c) c.Email = customer.Email)
                If existingCustomerByEmail IsNot Nothing Then
                    ModelState.AddModelError("Email", "Email address already exists.")
                    Return View(customer)
                End If

                ' Adds the new customer to the database and saves changes.
                db.Customers.Add(customer)
                db.SaveChanges()

                ' Redirects to the index page after successful creation.
                Return RedirectToAction("Index")
            End If

            ' Returns the view with validation errors if the model state is invalid.
            Return View(customer)
        End Function

        ' GET: Customers/Edit/5
        ' Retrieves and displays the form to edit a specific customer identified by id.
        Function Edit(ByVal id As Integer?) As ActionResult
            ' Checks if the id is provided. If not, returns a bad request status.
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            ' Finds the customer by id. If not found, returns a 404 Not Found status.
            Dim customer As Customer = db.Customers.Find(id)
            If IsNothing(customer) Then
                Return HttpNotFound()
            End If

            ' Returns the view for editing the customer details.
            Return View(customer)
        End Function

        ' POST: Customers/Edit/5
        ' Handles the form submission for updating a specific customer.

        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="CustomerID,Name,Email,RegistrationDate")> ByVal customer As Customer) As ActionResult
            ' Checks if the model state is valid.
            If ModelState.IsValid Then
                ' Checks for uniqueness of the name among other customers with different IDs.
                Dim existingCustomerByName = db.Customers.FirstOrDefault(Function(c) c.Name = customer.Name AndAlso c.CustomerID <> customer.CustomerID)
                If existingCustomerByName IsNot Nothing Then
                    ModelState.AddModelError("Name", "Customer name already exists.")
                    Return View(customer)
                End If

                ' Checks for uniqueness of the email among other customers with different IDs.
                Dim existingCustomerByEmail = db.Customers.FirstOrDefault(Function(c) c.Email = customer.Email AndAlso c.CustomerID <> customer.CustomerID)
                If existingCustomerByEmail IsNot Nothing Then
                    ModelState.AddModelError("Email", "Email address already exists.")
                    Return View(customer)
                End If

                ' Marks the customer entity as modified and saves changes to the database.
                db.Entry(customer).State = EntityState.Modified
                db.SaveChanges()
                ' Redirects to the index page after successful update.
                Return RedirectToAction("Index")
            End If

            ' Returns the view with validation errors if the model state is invalid.
            Return View(customer)
        End Function

        ' GET: Customers/Delete/5
        ' Retrieves and displays the confirmation view for deleting a specific customer identified by id.
        Function Delete(ByVal id As Integer?) As ActionResult
            ' Checks if the id is provided. If not, returns a bad request status.
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            ' Finds the customer by id. If not found, returns a 404 Not Found status.
            Dim customer As Customer = db.Customers.Find(id)
            If IsNothing(customer) Then
                Return HttpNotFound()
            End If

            ' Returns the view for confirming the deletion of the customer.
            Return View(customer)
        End Function

        ' POST: Customers/Delete/5
        ' Handles the form submission for deleting a specific customer.
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            ' Finds the customer by id and removes it from the database.
            Dim customer As Customer = db.Customers.Find(id)
            db.Customers.Remove(customer)
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
