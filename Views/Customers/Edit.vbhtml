@ModelType ProductCustomerManagement.Customer
<!-- Customer/Edit.vbhtml -->

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
    <h4>Customer</h4>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    @Html.HiddenFor(Function(model) model.CustomerID)

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Name, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Email, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Email, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Email, "", New With {.class = "text-danger"})
        </div>
    </div>

    @* Replaced EditorFor with TextBoxFor helper to implement Datepicker *@
    <div class="form-group mb-4">
        <!-- Added mb-4 to increase space below -->
        @Html.LabelFor(Function(model) model.RegistrationDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.TextBoxFor(Function(model) model.RegistrationDate, "{0:yyyy-MM-dd}", New With {.class = "form-control", .type = "date"})
            @Html.ValidationMessageFor(Function(model) model.RegistrationDate, "", New With {.class = "text-danger"})
        </div>
    </div>

    <!-- Save and Back to List buttons in the same row -->
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10 d-flex justify-content-start">
            <input type="submit" value="Save" class="btn btn-primary" />
            <a href="@Url.Action("Index", "Customers")" class="btn btn-secondary custom-btn-space">Back</a>
        </div>
    </div>

</div>
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
