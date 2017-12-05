@ModelType PDHR.EmpSalaryComponent
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>EmpSalaryComponent</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Amount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Amount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmployeeSalaryMast.FYMasterFY)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmployeeSalaryMast.FYMasterFY)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SalaryComponentMast.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SalaryComponentMast.Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
