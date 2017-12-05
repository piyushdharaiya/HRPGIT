@ModelType IEnumerable(Of PDHR.EmpLeaf)
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
            @Html.DisplayNameFor(Function(model) model.FromDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Todate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Remarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LeaveDays)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LeaveStatus)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmployeeMast.Fname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LeaveMast.LeaveName)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FromDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Todate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Remarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LeaveDays)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LeaveStatus)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmployeeMast.Fname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LeaveMast.LeaveName)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
