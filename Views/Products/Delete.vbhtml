@ModelType ProductCustomerManagement.Product
<!-- Product/Delete.vbhtml -->

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @*Updated Delete button And Back to List link with appropriate styling And alignment*@
        @<div Class="form-actions no-color d-flex justify-content-start mt-3">
            <input type = "submit" value="Delete" Class="btn btn-danger" />
            <a href = "@Url.Action("Index", "Products")" Class="btn btn-secondary custom-btn-space">Back</a>
        </div>
    End Using
</div>