@ModelType ProductCustomerManagement.Product
<!-- Product/Details.vbhtml -->

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Product</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Category)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Category)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Price)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Price)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Stock)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Stock)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LaunchDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LaunchDate)
        </dd>

    </dl>
</div>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.ProductID}) |
    @Html.ActionLink("Back to List", "Index")*@

    <!-- Updated Edit button and Back to List link with appropriate styling and alignment -->
    <div class="form-actions no-color d-flex justify-content-start mt-3">
        <a href="@Url.Action("Edit", New With {.id = Model.ProductID})" class="btn btn-primary">Edit</a>
        <a href="@Url.Action("Index")" class="btn btn-secondary custom-btn-space">Back</a>
    </div>
</p>
