@ModelType IEnumerable(Of PDHR.EmployerMast)
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
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        @*<th>
                @Html.DisplayNameFor(Function(model) model.PANNo)
            </th>*@
        @*<th>
                @Html.DisplayNameFor(Function(model) model.remarks)
            </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.City)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.State)
        </th>
        @*<th>
                @Html.DisplayNameFor(Function(model) model.Address)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Pincode)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Emailid)
            </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.isactive)
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
                @Html.DisplayFor(Function(modelItem) item.Name)
            </td>
            @*<td>
                    @Html.DisplayFor(Function(modelItem) item.PANNo)
                </td>*@
            @*<td>
                    @Html.DisplayFor(Function(modelItem) item.remarks)
                </td>*@
            <td>
                @Html.DisplayFor(Function(modelItem) item.City)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.State)
            </td>
            @*<td>
                    @Html.DisplayFor(Function(modelItem) item.Address)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Pincode)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Emailid)
                </td>*@
            <td>
                @Html.DisplayFor(Function(modelItem) item.isactive)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.FYMaster.FY)
            </td>

            <td>
                @Html.ActionLink("Salary", "GenrateSalary", New With {.CC = item.cc}) |
                @Html.ActionLink("Employee", "../EmployeeMasts/index", New With {.CC = item.cc}) |
                @Html.ActionLink("Leave", "../LeaveMasts/index", New With {.CC = item.cc}) |
                @Html.ActionLink("Holiday", "../HolidaysMasts/index", New With {.CC = item.cc}) |
                @Html.ActionLink("Edit", "Edit", New With {.id = item.cc}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.cc}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.cc})
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