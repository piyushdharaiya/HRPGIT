﻿@ModelType IEnumerable(Of PDHR.EmpMonthlyComponet)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.amount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmpMonthlySalary.Id)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmpSalaryComponent.Id)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.amount)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmpMonthlySalary.Id)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmpSalaryComponent.Id)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
