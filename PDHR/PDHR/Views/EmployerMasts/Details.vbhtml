@ModelType PDHR.EmployerMast
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>EmployerMast</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PANNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PANNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.remarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.remarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.City)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.City)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.State)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.State)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Address)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Pincode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Pincode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Emailid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Emailid)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.isactive)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.isactive)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.cc }) |
    @Html.ActionLink("Back to List", "Index")
</p>
