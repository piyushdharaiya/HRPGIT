<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My HR Application</title>
    
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
               
                @Html.ActionLink("PD HR", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul id="nav" class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                    <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                    <li>
                        <a>Master Data</a>
                        <ul class="nav navbar-nav">
                            <li>@Html.ActionLink("FY", "Index", "FYMasters")</li>
                            <li>@Html.ActionLink("Department", "Index", "DeptMasts")</li>
                            <li>@Html.ActionLink("Salary Component", "Index", "SalaryComponentMasts")</li>
                            <li>@Html.ActionLink("Employee Level", "Index", "EmpLevels")</li>
                            <li>
                                <a>Leave Master</a>
                                <ul class="nav navbar-nav">
                                    <li>@Html.ActionLink("Leave Master", "Index", "LeaveMasts")</li>
                                    <li>@Html.ActionLink("Holidays Master", "Index", "HolidaysMasts")</li>
                                </ul>
                            </li>

                        </ul>
                    </li>
                    <li>
                        <a>Employer Data</a>
                        <ul class="nav navbar-nav">
                            <li>@Html.ActionLink("Employer Master", "Index", "EmployerMasts")</li>

                        </ul>
                    </li>
                    <li>
                        <a href="#">Employee Data</a>
                        <ul class="nav navbar-nav">
                            <li>@Html.ActionLink("Employee", "Index", "EmployeeMasts")</li>
                            <li>@Html.ActionLink("Employee Salary", "Index", "EmployeeSalaryMasts")</li>
                            <li>@Html.ActionLink("employee Salary Comp.", "Index", "EmpSalaryComponents")</li>
                            <li>@Html.ActionLink("Employee Leave", "Index", "EmpLeaves")</li>
                        </ul>
                    </li>
                </ul>

                @Html.Partial("_LoginPartial")
            </div>

        </div>
    </div>

    <div class="container body-content">
        @*<ul class="nav navbar-nav">
            <li>@Html.ActionLink("Department", "Index", "DeptMasts")</li>
            <li>@Html.ActionLink("Employee Level", "Index", "EmpLevels")</li>
            <li>@Html.ActionLink("Leave Master", "Index", "LeaveMasts")</li>
            <li>@Html.ActionLink("Holidays Master", "Index", "HolidaysMasts")</li>
            <li>@Html.ActionLink("Employee", "Index", "EmployeeMasts")</li>
            <li>@Html.ActionLink("Employee Salary", "Index", "EmployeeSalaryMasts")</li>
            <li>@Html.ActionLink("Employer Master", "Index", "EmployerMasts")</li>
            <li>@Html.ActionLink("employee Salary Comp.", "Index", "EmpSalaryComponents")</li>
            <li>@Html.ActionLink("Employee Leave", "Index", "EmpLeaves")</li>
            <li>@Html.ActionLink("Salary Component", "Index", "SalaryComponentMasts")</li>
            </ul>*@
        @RenderBody()
        <hr />


        <footer>
            <p>&copy; @DateTime.Now.Year - PD HR</p>
        </footer>
    </div>

 
</body>
</html>
@Styles.Render("~/Content/css")
@Scripts.Render("~/bundles/modernizr")
@Scripts.Render("~/bundles/jquery")
 
@RenderSection("scripts", required:=False)
<style>
    #nav ul {
        display: none;
    }

    #nav li:hover > ul {
        display: block;
    }
</style>