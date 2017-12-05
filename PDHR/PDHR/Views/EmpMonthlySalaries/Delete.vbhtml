@ModelType PDHR.EmpMonthlySalary
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>EmpMonthlySalary</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.WorkingMonthDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WorkingMonthDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TotalDays)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TotalDays)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WorkingDays)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WorkingDays)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LeaveDays)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LeaveDays)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TotalSalaryAmount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TotalSalaryAmount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OnhandAmount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OnhandAmount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Deductamount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Deductamount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmployeeSalaryMast.FYMasterFY)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmployeeSalaryMast.FYMasterFY)
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
