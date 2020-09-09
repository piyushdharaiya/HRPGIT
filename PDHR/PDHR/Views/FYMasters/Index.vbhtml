@ModelType IEnumerable(Of PDHR.FYMaster)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table" id="Detp">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.FY)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.FY)
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.FY}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.FY}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.FY})
                </td>
            </tr>
        Next
    </tbody>
</table>

@section Scripts
<script>
    $(document).ready(function () {
        $('#Detp').DataTable();
    });
    
</script>
End Section


