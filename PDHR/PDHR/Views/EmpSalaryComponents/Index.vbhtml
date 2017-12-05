@ModelType IEnumerable(Of PDHR.EmpSalaryComponent)
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
            @Html.DisplayNameFor(Function(model) model.Amount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmployeeSalaryMast.FYMasterFY)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SalaryComponentMast.Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Amount)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmployeeSalaryMast.FYMasterFY)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SalaryComponentMast.Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
