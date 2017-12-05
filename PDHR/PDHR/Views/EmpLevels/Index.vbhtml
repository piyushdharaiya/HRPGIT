@ModelType IEnumerable(Of PDHR.EmpLevel)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table" id="table"><thead>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.LevelName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.wfd)
        </th>
        <th></th>
    </tr>
</thead><tbody>
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.LevelName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.wfd)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
            </td>
        </tr>
    Next
</tbody>
</table>

@section Scripts
    <script>
    $(document).ready(function () {
        $('#table').DataTable();
    });

    </script>
End Section