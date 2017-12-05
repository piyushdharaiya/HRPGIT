@ModelType PDHR.FYMaster
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>FYMaster</h4>
    <hr />
    <dl class="dl-horizontal">
    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.FY }) |
    @Html.ActionLink("Back to List", "Index")
</p>
