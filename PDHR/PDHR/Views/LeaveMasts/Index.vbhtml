@ModelType IEnumerable(Of PDHR.LeaveMast)
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
            @Html.DisplayNameFor(Function(model) model.LeaveName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NoofDays)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.wfd)
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
            @Html.DisplayFor(Function(modelItem) item.LeaveName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NoofDays)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.wfd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmployerMast.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FYMaster.FY)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
