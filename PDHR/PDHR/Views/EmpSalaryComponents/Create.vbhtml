@ModelType PDHR.EmpSalaryComponent
@Code
    ViewData("Title") = "Create"
End Code
<h2>Create</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>EmpSalaryComponent</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Amount, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Amount, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Amount, "", New With {.class = "text-danger"})
                @Html.ActionLink("Get Amount", "GetComponetAmount", {1, 1})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.EmployeeSalaryMastId, "EmployeeSalaryMastId", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("EmployeeSalaryMastId", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.EmployeeSalaryMastId, "", New With {.class = "text-danger"})
            </div>
        </div>
         <script type="text/javascript">
    // assuming you're using jQuery

    $("#SalaryComponentMastId").change(function (event) {
        var  EmployeeSalaryMastId =model.EmployeeSalaryMastId;

        jQuery.ajax({
            url: '@Url.Action("GetComponetAmount", "EmpSalaryComponents")',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify({ EmployeeSalaryMastId : EmployeeSalaryMastId,  componetid: $(this).val() }),
            success: function (result) { }
        });
    });
         </script>
         <div class="form-group">
            @Html.LabelFor(Function(model) model.SalaryComponentMastId, "SalaryComponentMastId", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("SalaryComponentMastId", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.SalaryComponentMastId, "", New With {.class = "text-danger"})
            </div>
        </div>

     

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
