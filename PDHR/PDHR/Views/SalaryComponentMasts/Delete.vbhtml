@ModelType PDHR.SalaryComponentMast
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>SalaryComponentMast</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.wfd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.wfd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CompType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CompType)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TypeRsPer)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TypeRsPer)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.amount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.amount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.basedoncomponent)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.basedoncomponent)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Compcalcutiontype)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Compcalcutiontype)
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
