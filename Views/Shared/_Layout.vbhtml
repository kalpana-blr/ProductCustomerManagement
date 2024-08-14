<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <!-- Set the title of the page dynamically based on the ViewBag.Title property -->
    <title>@ViewBag.Title Product and Customer Management </title>

    <!-- Render CSS styles bundled in "~/Content/css" -->
    @Styles.Render("~/Content/css")
    <!-- Render Modernizr script bundle (for HTML5 and CSS3 feature detection) -->
    @Scripts.Render("~/bundles/modernizr")

    <!-- Load jQuery library necessary for jQuery UI and Bootstrap, (Load jQuery first before the jQuery UI and Bootstrap) -->
    <script src="~/Scripts/jquery-3.7.0.min.js"></script>

    <!-- Load jQuery Validation library (for form validation) -->
    <script src="~/Scripts/jquery.validate.min.js"></script>
    <!-- jQuery Validation Unobtrusive library -->
    <script src="~/Scripts/jquery.validate.unobtrusive.min.js"></script>

    <!-- Link to the jQuery UI CSS for styling the datepicker -->
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <!-- Load jQuery UI library (for widgets like the datepicker) -->
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>

    <!-- Link to the Bootstrap CSS for responsive design and styling -->
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <!-- Load Bootstrap JS library (for Bootstrap components like modals and dropdowns) -->
    <script src="~/Scripts/bootstrap.min.js"></script>

    <!-- Link to the FontAwesome CSS for action icons -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" rel="stylesheet" />

</head>
<body>
    <!-- Navbar for navigation links -->
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
        <div class="container">
            @Html.ActionLink("Product and Customer Management", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})

            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <li>@Html.ActionLink("Home", "Index", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Products", "Index", "Products", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Customers", "Index", "Customers", New With {.area = ""}, New With {.class = "nav-link"})</li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- Main content container -->
    <div class="container body-content">
        <!-- Render the view-specific content here -->
        @RenderBody()

        <hr />

        <!-- Footer section -->
        <footer>
            <p>&copy; @DateTime.Now.Year WITHYOUWITHME</p>
        </footer>
    </div>

    <!-- Render the jQuery script bundle -->
    @Scripts.Render("~/bundles/jquery")
    <!-- Render additional scripts if defined in the view -->
    @Scripts.Render("~/bundles/bootstrap")
    <!-- Render additional scripts if defined in the view -->
    @RenderSection("scripts", required:=False)

    <!-- Initialize the datepicker for input elements of type 'date' -->
    <script>
        $(document).ready(function () {
            $("input[type='date']").datepicker({
                // Set the date format to match yyyy-MM-dd
                dateFormat: "yy-mm-dd"
            });
        });
    </script>
</body>
</html>