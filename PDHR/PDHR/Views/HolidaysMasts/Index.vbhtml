@ModelType IEnumerable(Of PDHR.HolidaysMast)
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
            @Html.DisplayNameFor(Function(model) model.HolidaysName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.HolidaysDate)
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
</thead><tbody>
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.HolidaysName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.HolidaysDate)
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