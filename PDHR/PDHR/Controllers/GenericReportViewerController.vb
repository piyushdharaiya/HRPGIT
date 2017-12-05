
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Namespace Controllers
    Public Class GenericReportViewerController
        Inherits Controller
        '
        ' GET: /GenericReportViewer/

        Public Function Index() As ActionResult
            Return View()
        End Function


        Public Sub ShowGenericRpt(id As Double)
            Try
                Dim isValid As Boolean = True

                Dim strReportName As String = "PaySlip.rpt" 'System.Web.HttpContext.Current.Session("ReportName").ToString()
                ' Setting ReportName
                '   Dim strFromDate As String = System.Web.HttpContext.Current.Session("rptFromDate").ToString()
                ' Setting FromDate 
                '  Dim strToDate As String = System.Web.HttpContext.Current.Session("rptToDate").ToString()
                ' Setting ToDate   


                '  Dim rptSource = Session("rptSource")

                If String.IsNullOrEmpty(strReportName) Then
                    isValid = False
                End If

                If isValid Then
                    Dim rd As New ReportDocument()
                    Dim strRptPath As String = Convert.ToString(System.Web.HttpContext.Current.Server.MapPath("~/") + "Rpts//") & strReportName

                    rd.Load(strRptPath)
                    rd.SetDatabaseLogon("sa", "piyush", "PDHRP", "HRP1")
                    rd.RecordSelectionFormula = "{EmpMonthlySalaries.id}=" + id.ToString
                    'If rptSource IsNot Nothing AndAlso rptSource.[GetType]().ToString() <> "System.String" Then
                    '    rd.SetDataSource(rptSource)
                    'End If
                    'If Not String.IsNullOrEmpty(strFromDate) Then
                    '    rd.SetParameterValue("fromDate", strFromDate)
                    'End If
                    'If Not String.IsNullOrEmpty(strToDate) Then
                    '    rd.SetParameterValue("toDate", strFromDate)
                    'End If
                    rd.ExportToHttpResponse(ExportFormatType.PortableDocFormat, System.Web.HttpContext.Current.Response, False, "crReport")


                    ' Clear all sessions value
                    Session("ReportName") = Nothing
                    Session("rptFromDate") = Nothing
                    Session("rptToDate") = Nothing
                    Session("rptSource") = Nothing
                Else
                    Response.Write("<H2>Nothing Found; No Report name found</H2>")
                End If
            Catch ex As Exception
                Response.Write(ex.ToString())
            End Try
        End Sub
    End Class
End Namespace

