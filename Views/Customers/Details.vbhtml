@ModelType ProductCustomerManagement.Customer
<!-- Customer/Details.vbhtml -->

@Code
    ' Set the title of the page to "Details"
    ViewData("Title") = "Details"
End Code

@* Display the page header *@
<h2>Details</h2>

@* Main container for the customer details*@
<div>
    <h4>Customer</h4>
    <hr />
    @* Definition list to display the customer's properties in a structured way*@
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RegistrationDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RegistrationDate)
        </dd>

    </dl>
</div>
@* Action links for editing the current customer or returning to the list of customers*@
<p>  
    <!-- Updated Edit button and Back to List link with appropriate styling and alignment -->
    <div class="form-actions no-color d-flex justify-content-start mt-3">
        <a href="@Url.Action("Edit", New With {.id = Model.CustomerID})" class="btn btn-primary">Edit</a>
        <a href="@Url.Action("Index")" class="btn btn-secondary custom-btn-space">Back</a>
    </div>
</p>
