@Code
    ViewData("Title") = "ReportsViewer"
End Code
<script type="text/javascript">
    
    function GenericInNewWin() {
             window.open("../../GenericReportViewer/ShowGenericRpt", 'mywindow', 'fullscreen=yes, scrollbars=auto');
       }

</script>

<h2>ReportsViewer</h2>

     <input type = "button" value= "Rpt from MVC with new window" onclick="GenericInNewWin()" />
