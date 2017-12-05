@ModelType PDHR.LeaveMast
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>LeaveMast</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.LeaveName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LeaveName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NoofDays)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NoofDays)
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
