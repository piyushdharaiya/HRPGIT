﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class HRPEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=HRPEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property DeptMasts() As DbSet(Of DeptMast)
    Public Overridable Property EmpLeaves() As DbSet(Of EmpLeaves)
    Public Overridable Property EmpLevels() As DbSet(Of EmpLevel)
    Public Overridable Property EmployeeSalaryMasts() As DbSet(Of EmployeeSalaryMast)
    Public Overridable Property EmployerMasts() As DbSet(Of EmployerMast)
    Public Overridable Property EmpMonthlyComponets() As DbSet(Of EmpMonthlyComponet)
    Public Overridable Property EmpMonthlySalaries() As DbSet(Of EmpMonthlySalary)
    Public Overridable Property EmpSalaryComponents() As DbSet(Of EmpSalaryComponent)
    Public Overridable Property FYMasters() As DbSet(Of FYMaster)
    Public Overridable Property HolidaysMasts() As DbSet(Of HolidaysMast)
    Public Overridable Property LeaveMasts() As DbSet(Of LeaveMast)
    Public Overridable Property SalaryComponentMasts() As DbSet(Of SalaryComponentMast)
    Public Overridable Property EmployeeMasts() As DbSet(Of EmployeeMast)

End Class
