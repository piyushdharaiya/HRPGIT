@ModelType PDHR.EmployeeSalaryMast
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>EmployeeSalaryMast</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.wfd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.wfd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CTCMonthly)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CTCMonthly)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CTCYear)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CTCYear)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Fixcompamt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fixcompamt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.flexcompamt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.flexcompamt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmployeeMast.Fname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmployeeMast.Fname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FYMaster.FY)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FYMaster.FY)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
