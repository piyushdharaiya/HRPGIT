@ModelType IEnumerable(Of PDHR.EmployeeMast)
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
            @Html.DisplayNameFor(Function(model) model.Fname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Lname)
        </th>
         <th>
            @Html.DisplayNameFor(Function(model) model.city)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.State)
        </th>
         <th>
            @Html.DisplayNameFor(Function(model) model.isactive)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DeptMast.Dept_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmpLevel.LevelName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmployerMast.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FYMaster.FY)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Fname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Lname)
        </td>
         <td>
            @Html.DisplayFor(Function(modelItem) item.city)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.State)
        </td>
         <td>
            @Html.DisplayFor(Function(modelItem) item.isactive)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DeptMast.Dept_Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmpLevel.LevelName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmployerMast.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FYMaster.FY)
        </td>
        <td>
            @Html.ActionLink("Salary Details", "../EmployeeSalaryMasts/index", New With {.id = item.Id}) |
            @Html.ActionLink("Leave Details", "../EmpLeaves/index", New With {.id = item.Id}) |
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
