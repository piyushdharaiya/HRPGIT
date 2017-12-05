@ModelType IEnumerable(Of PDHR.EmployeeSalaryMast)
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
            @Html.DisplayNameFor(Function(model) model.wfd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CTCMonthly)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CTCYear)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Fixcompamt)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.flexcompamt)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmployeeMast.Fname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FYMaster.FY)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.wfd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CTCMonthly)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CTCYear)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Fixcompamt)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.flexcompamt)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmployeeMast.Fname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FYMaster.FY)
        </td>
        <td>
            @Html.ActionLink("Salary Comp.", "../EmpSalaryComponents/index", New With {.id = item.Id}) |
            @Html.ActionLink("Monthly Salary", "../EmpMonthlySalaries/index", New With {.id = item.Id}) |
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
