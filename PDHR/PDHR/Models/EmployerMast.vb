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

Partial Public Class EmployerMast
    Public Property cc As Integer
    Public Property Name As String
    Public Property PANNo As String
    Public Property remarks As String
    Public Property City As String
    Public Property State As String
    Public Property Address As String
    Public Property Pincode As String
    Public Property Emailid As String
    Public Property isactive As Nullable(Of Boolean)
    Public Property FYMasterFY As String

    Public Overridable Property EmployeeMasts As ICollection(Of EmployeeMast) = New HashSet(Of EmployeeMast)
    Public Overridable Property HolidaysMasts As ICollection(Of HolidaysMast) = New HashSet(Of HolidaysMast)
    Public Overridable Property LeaveMasts As ICollection(Of LeaveMast) = New HashSet(Of LeaveMast)
    Public Overridable Property FYMaster As FYMaster

End Class
