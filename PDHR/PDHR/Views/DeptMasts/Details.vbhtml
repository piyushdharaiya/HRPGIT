@ModelType PDHR.DeptMast
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>DeptMast</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Dept_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Dept_Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
