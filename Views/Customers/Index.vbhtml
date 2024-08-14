@ModelType IEnumerable(Of ProductCustomerManagement.Customer)
@Code
    'ViewData("Title") = "Index"
    ViewData("Title") = "Customers"
End Code

@*<h2>Index</h2>*@
<h2>Customers</h2>
<p>
    @Html.ActionLink("New Customer", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.RegistrationDate)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Email)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.RegistrationDate)
            </td>
            <td>
                @*@Html.ActionLink("Edit", "Edit", New With {.id = item.CustomerID}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.CustomerID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.CustomerID})*@

                <!-- Replaced Html.ActionLink with Url.Action to replace the Text Links with Font Awesome icons Edit, Delete and Details  -->
                <a href="@Url.Action("Edit", "Customers", New With {.id = item.CustomerID})" class="icon-link" title="Edit Customer" aria-label="Edit">
                    <i class="fas fa-edit text-primary fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Edit</span>
                </a>
                <a href="@Url.Action("Details", "Customers", New With {.id = item.CustomerID})" class="icon-link" title="View Details" aria-label="Details">
                    <i class="fas fa-info-circle text-info fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Details</span>
                </a>
                <a href="@Url.Action("Delete", "Customers", New With {.id = item.CustomerID})" title="Delete Customer" aria-label="Delete">
                    <i class="fas fa-trash-alt text-danger fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Delete</span>
                </a>

            </td>
        </tr>
    Next

</table>
