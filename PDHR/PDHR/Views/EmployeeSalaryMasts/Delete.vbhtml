@ModelType PDHR.EmployeeSalaryMast
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>EmployeeSalaryMast</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.wfd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.wfd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CTCMonthly)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CTCMonthly)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CTCYear)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CTCYear)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Fixcompamt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fixcompamt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.flexcompamt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.flexcompamt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmployeeMast.Fname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmployeeMast.Fname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FYMaster.FY)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FYMaster.FY)
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
