Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Namespace Controllers
    Public Class ReportsViewerController
        Inherits Controller
        '
        ' GET: /FromMvc/

        Public Function Index() As ActionResult
            Return View()
        End Function

        'Used for showing simple report
        Public Sub ShowSimple()

            Using rptH As New ReportClass()

                rptH.FileName = Server.MapPath("~/") + "//Rpts//paySlip.rpt"
                rptH.SetDatabaseLogon("SA", "piyush")
                rptH.Load()
                rptH.ExportToHttpResponse(ExportFormatType.PortableDocFormat, System.Web.HttpContext.Current.Response, False, "crReport")
            End Using
        End Sub


        ''' <summary>
        ''' Generating Report Data
        ''' </summary>
        ''' <returns></returns>
        Private Function GetStudents() As List(Of EmployerMast)
            Dim db As New HRP1Entities
            Return db.EmployerMasts.ToList()
        End Function


        Public Function ShowGeneric() As ActionResult

            Me.HttpContext.Session("ReportName") = "paySlip.rpt"
            'Me.HttpContext.Session("rptFromDate") = txtFromDate
            'Me.HttpContext.Session("rptToDate") = txtToDate
            Me.HttpContext.Session("rptSource") = GetStudents()


            Return RedirectToAction("ShowGenericRpt", "GenericReportViewer")
        End Function

        <HttpPost>
        Public Sub ShowGenericRptInNewWin()
            Me.HttpContext.Session("ReportName") = "paySlip.rpt"
            'Me.HttpContext.Session("rptFromDate") = FromDate
            'Me.HttpContext.Session("rptToDate") = ToDate
            Me.HttpContext.Session("rptSource") = GetStudents()

        End Sub


    End Class



End Namespace

