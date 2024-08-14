@ModelType ProductCustomerManagement.Customer
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
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.CustomerID}) |
    @Html.ActionLink("Back to List", "Index")
</p>
