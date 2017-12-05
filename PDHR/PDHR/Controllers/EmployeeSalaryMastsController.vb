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
    Public Class EmployeeSalaryMastsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: EmployeeSalaryMasts
        Function Index(ByVal id As Integer?) As ActionResult
            Dim employeeSalaryMasts = db.EmployeeSalaryMasts.Include(Function(e) e.EmployeeMast).Include(Function(e) e.FYMaster).Where(Function(e) e.EmployeeMastId = id)
            Return View(employeeSalaryMasts.ToList())
        End Function

        ' GET: EmployeeSalaryMasts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeSalaryMast As EmployeeSalaryMast = db.EmployeeSalaryMasts.Find(id)
            If IsNothing(employeeSalaryMast) Then
                Return HttpNotFound()
            End If
            Return View(employeeSalaryMast)
        End Function

        ' GET: EmployeeSalaryMasts/Create
        Function Create() As ActionResult
            ViewBag.EmployeeMastId = New SelectList(db.EmployeeMasts, "Id", "Fname")
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY")
            Return View()
        End Function

        ' POST: EmployeeSalaryMasts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,wfd,CTCMonthly,CTCYear,Fixcompamt,flexcompamt,EmployeeMastId,FYMasterFY")> ByVal employeeSalaryMast As EmployeeSalaryMast) As ActionResult
            If ModelState.IsValid Then
                db.EmployeeSalaryMasts.Add(employeeSalaryMast)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployeeMastId = New SelectList(db.EmployeeMasts, "Id", "Fname", employeeSalaryMast.EmployeeMastId)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", employeeSalaryMast.FYMasterFY)
            Return View(employeeSalaryMast)
        End Function

        ' GET: EmployeeSalaryMasts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeSalaryMast As EmployeeSalaryMast = db.EmployeeSalaryMasts.Find(id)
            If IsNothing(employeeSalaryMast) Then
                Return HttpNotFound()
            End If
            ViewBag.EmployeeMastId = New SelectList(db.EmployeeMasts, "Id", "Fname", employeeSalaryMast.EmployeeMastId)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", employeeSalaryMast.FYMasterFY)
            Return View(employeeSalaryMast)
        End Function

        ' POST: EmployeeSalaryMasts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,wfd,CTCMonthly,CTCYear,Fixcompamt,flexcompamt,EmployeeMastId,FYMasterFY")> ByVal employeeSalaryMast As EmployeeSalaryMast) As ActionResult
            If ModelState.IsValid Then
                db.Entry(employeeSalaryMast).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployeeMastId = New SelectList(db.EmployeeMasts, "Id", "Fname", employeeSalaryMast.EmployeeMastId)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", employeeSalaryMast.FYMasterFY)
            Return View(employeeSalaryMast)
        End Function

        ' GET: EmployeeSalaryMasts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeSalaryMast As EmployeeSalaryMast = db.EmployeeSalaryMasts.Find(id)
            If IsNothing(employeeSalaryMast) Then
                Return HttpNotFound()
            End If
            Return View(employeeSalaryMast)
        End Function

        ' POST: EmployeeSalaryMasts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim employeeSalaryMast As EmployeeSalaryMast = db.EmployeeSalaryMasts.Find(id)
            db.EmployeeSalaryMasts.Remove(employeeSalaryMast)
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
