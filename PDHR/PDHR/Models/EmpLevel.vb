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

Partial Public Class EmpLevel
    Public Property Id As Integer
    Public Property LevelName As String
    Public Property wfd As Date

    Public Overridable Property EmployeeMasts As ICollection(Of EmployeeMast) = New HashSet(Of EmployeeMast)

End Class
