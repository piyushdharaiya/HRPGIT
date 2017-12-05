Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports PDHR

Namespace Controllers
    Public Class EmpMonthlySalariesController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: EmpMonthlySalaries
        Function Index(ByVal id As Integer?) As ActionResult
            Dim empMonthlySalaries = db.EmpMonthlySalaries.Where(Function(e) e.EmployeeSalaryMastId = id).Include(Function(e) e.EmployeeSalaryMast)
            Return View(empMonthlySalaries.ToList())
        End Function

        ' GET: EmpMonthlySalaries/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empMonthlySalary As EmpMonthlySalary = db.EmpMonthlySalaries.Find(id)
            If IsNothing(empMonthlySalary) Then
                Return HttpNotFound()
            End If
            Return View(empMonthlySalary)
        End Function

        ' GET: EmpMonthlySalaries/Create
        Function Create() As ActionResult
            ViewBag.EmployeeSalaryMastId = New SelectList(db.EmployeeSalaryMasts, "Id", "FYMasterFY")
            Return View()
        End Function

        ' POST: EmpMonthlySalaries/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,WorkingMonthDate,TotalDays,WorkingDays,LeaveDays,TotalSalaryAmount,OnhandAmount,Deductamount,EmployeeSalaryMastId")> ByVal empMonthlySalary As EmpMonthlySalary) As ActionResult
            If ModelState.IsValid Then
                db.EmpMonthlySalaries.Add(empMonthlySalary)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployeeSalaryMastId = New SelectList(db.EmployeeSalaryMasts, "Id", "FYMasterFY", empMonthlySalary.EmployeeSalaryMastId)
            Return View(empMonthlySalary)
        End Function

        ' GET: EmpMonthlySalaries/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empMonthlySalary As EmpMonthlySalary = db.EmpMonthlySalaries.Find(id)
            If IsNothing(empMonthlySalary) Then
                Return HttpNotFound()
            End If
            ViewBag.EmployeeSalaryMastId = New SelectList(db.EmployeeSalaryMasts, "Id", "FYMasterFY", empMonthlySalary.EmployeeSalaryMastId)
            Return View(empMonthlySalary)
        End Function

        ' POST: EmpMonthlySalaries/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,WorkingMonthDate,TotalDays,WorkingDays,LeaveDays,TotalSalaryAmount,OnhandAmount,Deductamount,EmployeeSalaryMastId")> ByVal empMonthlySalary As EmpMonthlySalary) As ActionResult
            If ModelState.IsValid Then
                db.Entry(empMonthlySalary).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployeeSalaryMastId = New SelectList(db.EmployeeSalaryMasts, "Id", "FYMasterFY", empMonthlySalary.EmployeeSalaryMastId)
            Return View(empMonthlySalary)
        End Function

        ' GET: EmpMonthlySalaries/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empMonthlySalary As EmpMonthlySalary = db.EmpMonthlySalaries.Find(id)
            If IsNothing(empMonthlySalary) Then
                Return HttpNotFound()
            End If
            Return View(empMonthlySalary)
        End Function

        ' POST: EmpMonthlySalaries/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empMonthlySalary As EmpMonthlySalary = db.EmpMonthlySalaries.Find(id)
            db.EmpMonthlySalaries.Remove(empMonthlySalary)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
