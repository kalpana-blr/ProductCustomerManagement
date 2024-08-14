﻿@ModelType ProductCustomerManagement.Product
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

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
