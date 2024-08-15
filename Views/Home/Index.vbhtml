@ModelType Object
<!-- Home/Index.vbhtml -->

<!-- Display list of Products with action to Add , Edit & Delete Product  -->
<h2>Products</h2>
<table class="table">
    <tr>
        <th>ProductID</th>
        <th>Name</th>
        <th>Category</th>
        <th>Price</th>
        <th>Stock</th>
        <th>Launch Date</th>
        @*<th>Actions</th>*@
        <th></th>
    </tr>
    @For Each product In ViewBag.Products
        @<tr>
            <td>@product.ProductID</td>
            <td>@product.Name</td>
            <td>@product.Category</td>
            <td>@product.Price</td>
            <td>@product.Stock</td>
            <td>@Convert.ToDateTime(product.LaunchDate).ToString("dd/MM/yyyy")</td>
            <td>
                <!-- Replaced Html.ActionLink with Url.Action to replace the Action Text Links with Font Awesome icons Edit, Delete  -->
                <!--  Product - Edit Icon  -->
                <a href="@Url.Action("Edit", "Products", New With {.id = product.ProductID})" class="icon-link" title="Edit Product" aria-label="Edit">
                    <i class="fas fa-edit text-primary fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Edit</span>
                </a>
                <!--  Product - Delete Icon  -->
                <a href="@Url.Action("Delete", "Products", New With {.id = product.ProductID})" title="Delete Product" aria-label="Delete">
                    <i class="fas fa-trash-alt text-danger fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Delete</span>
                </a>
            </td>
        </tr>
    Next
</table>

<!--  New Product button  -->
<div class="d-flex justify-content-end mb-3">
    <a href="@Url.Action("Create", "Products")" class="btn btn-primary" title="New Product" aria-label="New Product">
        <i class="fas fa-plus"></i> New Product
    </a>
</div>


<!-- Display list of Customers with action to Add , Edit & Delete Customer  -->
<h2>Customers</h2>
<table class="table">
    <tr>
        <th>CustomerID</th>
        <th>Name</th>
        <th>Email</th>
        <th>Registration Date</th>
        @*<th>Actions</th>*@
        <th></th>
    </tr>
    @For Each customer In ViewBag.Customers
        @<tr>
            <td>@customer.CustomerID</td>
            <td>@customer.Name</td>
            <td>@customer.Email</td>
            <td>@Convert.ToDateTime(customer.RegistrationDate).ToString("dd/MM/yyyy")</td>
            <td>
                <!-- Replaced Html.ActionLink with Url.Action to replace the Text Links with Font Awesome icons Edit, Delete  -->
                <!--  Customer - Edit Icon  -->
                <a href="@Url.Action("Edit", "Customers", New With {.id = customer.CustomerID})" class="icon-link" title="Edit Customer" aria-label="Edit">
                    <i class="fas fa-edit text-primary fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Edit</span>
                </a>
                <!--  Customer - Delete Icon  -->
                <a href="@Url.Action("Delete", "Customers", New With {.id = customer.CustomerID})" title="Delete Customer" aria-label="Delete">
                    <i class="fas fa-trash-alt text-danger fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Delete</span>
                </a>
            </td>
        </tr>
    Next
</table>

<!--  New Customer button  -->
<div class="d-flex justify-content-end mb-3">
    <a href="@Url.Action("Create", "Customers")" class="btn btn-success" title="New Customer" aria-label="New Customer">
        <i class="fas fa-user-plus"></i> New Customer
    </a>
</div>