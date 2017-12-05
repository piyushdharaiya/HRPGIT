@ModelType IEnumerable(Of PDHR.SalaryComponentMast)
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
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CompType)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TypeRsPer)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.amount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.basedoncomponent)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Compcalcutiontype)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.wfd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CompType)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TypeRsPer)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.amount)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.basedoncomponent)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Compcalcutiontype)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
