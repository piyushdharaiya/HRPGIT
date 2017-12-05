@ModelType PDHR.HolidaysMast
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
