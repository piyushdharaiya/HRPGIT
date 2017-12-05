@ModelType PDHR.EmpMonthlyComponet
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>EmpMonthlyComponet</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.amount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.amount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmpMonthlySalary.Id)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmpMonthlySalary.Id)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmpSalaryComponent.Id)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmpSalaryComponent.Id)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
