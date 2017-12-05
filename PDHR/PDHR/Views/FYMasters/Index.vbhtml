@ModelType IEnumerable(Of PDHR.FYMaster)
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
            @Html.DisplayNameFor(Function(model) model.FY)
        </th>
    </tr>

@For Each item In Model
    @<tr>
         <td>
             @Html.DisplayFor(Function(modelItem) item.FY)
         </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.FY }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.FY }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.FY })
        </td>
    </tr>
Next

</table>
