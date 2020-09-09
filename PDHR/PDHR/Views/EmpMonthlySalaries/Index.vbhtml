@ModelType IEnumerable(Of PDHR.EmpMonthlySalary)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>
<script type="text/javascript">

    function GenericInNewWin(id) {
             window.open("../../GenericReportViewer/ShowGenericRpt/"+id, 'mywindow', 'fullscreen=yes, scrollbars=auto');
       }

</script>
<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table" id="table"><thead>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.WorkingMonthDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TotalDays)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WorkingDays)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LeaveDays)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TotalSalaryAmount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OnhandAmount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Deductamount)
        </th>

        <th></th>
    </tr>
</thead><tbody>
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.WorkingMonthDate)

            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TotalDays)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.WorkingDays)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.LeaveDays)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TotalSalaryAmount)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.OnhandAmount)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Deductamount)
            </td>

            <td>
                <input type="button" value="PaySlipReport" onclick="GenericInNewWin(@item.Id)" />|

                @Html.ActionLink("Monthly Salary Componet", "../EmpMonthlyComponets/Index", New With {.id = item.Id}) |
                @*@Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })*@
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