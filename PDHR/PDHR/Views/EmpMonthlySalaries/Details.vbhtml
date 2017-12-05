@ModelType PDHR.EmpMonthlySalary
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
