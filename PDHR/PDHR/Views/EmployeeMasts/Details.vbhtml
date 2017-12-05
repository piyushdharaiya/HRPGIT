@ModelType PDHR.EmployeeMast
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>EmployeeMast</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Fname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Lname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Lname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DOB)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DOB)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PANno)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PANno)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UANNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UANNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ESINo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ESINo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PFNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PFNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.JoinofDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.JoinofDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.city)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.city)
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
            @Html.DisplayNameFor(Function(model) model.pinCode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.pinCode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Emailid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Emailid)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BankName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BankName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Accountno)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Accountno)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IFSCCode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IFSCCode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.isactive)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.isactive)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DeptMast.Dept_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DeptMast.Dept_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmpLevel.LevelName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmpLevel.LevelName)
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
