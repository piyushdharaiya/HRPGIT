@ModelType PDHR.EmpLeaf
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>EmpLeaf</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FromDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FromDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Todate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Todate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Remarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Remarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LeaveDays)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LeaveDays)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LeaveStatus)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LeaveStatus)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmployeeMast.Fname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmployeeMast.Fname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LeaveMast.LeaveName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LeaveMast.LeaveName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
