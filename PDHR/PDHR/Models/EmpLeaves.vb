'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class EmpLeaves
    Public Property Id As Integer
    Public Property FromDate As Date
    Public Property Todate As Date
    Public Property Remarks As String
    Public Property LeaveDays As Integer
    Public Property LeaveStatus As String
    Public Property EmployeeMastId As Integer
    Public Property LeaveMastId As Integer

    Public Overridable Property EmployeeMast As EmployeeMast
    Public Overridable Property LeaveMast As LeaveMast

End Class
