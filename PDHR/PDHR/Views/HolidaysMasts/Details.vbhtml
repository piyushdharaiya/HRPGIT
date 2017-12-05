@ModelType PDHR.HolidaysMast
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>HolidaysMast</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.HolidaysName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.HolidaysName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.HolidaysDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.HolidaysDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.wfd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.wfd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmployerMast.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmployerMast.Name)
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
