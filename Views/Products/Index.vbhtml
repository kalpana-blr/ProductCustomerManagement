@ModelType IEnumerable(Of ProductCustomerManagement.Product)
@Code
    'ViewData("Title") = "Index"
    ViewData("Title") = "Products"
End Code

@*<h2>Index</h2>*@
<h2>Products</h2>
<p>
    @Html.ActionLink("New Product", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Category)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Price)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Stock)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LaunchDate)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Category)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Price)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Stock)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.LaunchDate)
            </td>
            <td>
                @*@Html.ActionLink("Edit", "Edit", New With {.id = item.ProductID}) |
        @Html.ActionLink("Details", "Details", New With {.id = item.ProductID}) |
        @Html.ActionLink("Delete", "Delete", New With {.id = item.ProductID})*@

                <!-- Replaced Html.ActionLink with Url.Action to replace the Text Links with Font Awesome icons Edit, Delete and Details  -->
                <a href="@Url.Action("Edit", "Products", New With {.id = item.ProductID})" class="icon-link" title="Edit Product" aria-label="Edit">
                    <i class="fas fa-edit text-primary fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Edit</span>
                </a>
                <a href="@Url.Action("Details", "Products", New With {.id = item.ProductID})" class="icon-link" title="View Details" aria-label="Details">
                    <i class="fas fa-info-circle text-info fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Details</span>
                </a>
                <a href="@Url.Action("Delete", "Products", New With {.id = item.ProductID})" title="Delete Product" aria-label="Delete">
                    <i class="fas fa-trash-alt text-danger fa-lg" aria-hidden="true"></i>
                    <span class="sr-only">Delete</span>
                </a>
            </td>
        </tr>
    Next

</table>
