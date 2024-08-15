@ModelType IEnumerable(Of ProductCustomerManagement.Product)
<!-- Products/Index.vbhtml -->

@Code
    ViewData("Title") = "Products"
End Code

<h2>Products</h2>
<!-- Products Table -->
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
        <th class="actions-column"></th>
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
            <td class="actions-column">
                <!-- Replaced Html.ActionLink with Url.Action to replace the action Text Links with Font Awesome icons Edit, Details and Delete  -->
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

<!-- New Product Button -->
<div class="d-flex justify-content-end mb-3">
    <a href="@Url.Action("Create", "Products")" class="btn btn-primary" title="New Product" aria-label="New Product">
          <i class="fas fa-plus"></i> New Product
    </a> 
</div>