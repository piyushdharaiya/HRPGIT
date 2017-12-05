﻿@ModelType PDHR.EmpSalaryComponent
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
