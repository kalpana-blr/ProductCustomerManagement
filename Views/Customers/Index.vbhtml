@ModelType IEnumerable(Of ProductCustomerManagement.Customer)
<!--Customers/Index.vbhtml -->

@Code
    ViewData("Title") = "Customers"
End Code

<h2>Customers</h2>
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
        <th class="actions-column"></th>
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
            <td class="actions-column">
                <!-- Replaced Html.ActionLink with Url.Action to replace the action Text Links with Font Awesome icons Edit, Details and Delete -->
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

<!--  New Customer button  -->
<div class="d-flex justify-content-end mb-3">
    <a href="@Url.Action("Create", "Customers")" class="btn btn-success" title="New Customer" aria-label="New Customer">
        <i class="fas fa-user-plus"></i> New Customer
    </a>
</div>