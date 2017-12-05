@ModelType PDHR.SalaryComponentMast
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
