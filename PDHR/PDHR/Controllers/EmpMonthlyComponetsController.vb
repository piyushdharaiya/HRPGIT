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
    Public Class EmpMonthlyComponetsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: EmpMonthlyComponets
        Function Index() As ActionResult
            Dim empMonthlyComponets = db.EmpMonthlyComponets.Include(Function(e) e.EmpMonthlySalary).Include(Function(e) e.EmpSalaryComponent)
            Return View(empMonthlyComponets.ToList())
        End Function

        ' GET: EmpMonthlyComponets/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empMonthlyComponet As EmpMonthlyComponet = db.EmpMonthlyComponets.Find(id)
            If IsNothing(empMonthlyComponet) Then
                Return HttpNotFound()
            End If
            Return View(empMonthlyComponet)
        End Function

        ' GET: EmpMonthlyComponets/Create
        Function Create() As ActionResult
            ViewBag.EmpMonthlySalaryId = New SelectList(db.EmpMonthlySalaries, "Id", "Id")
            ViewBag.EmpSalaryComponentId = New SelectList(db.EmpSalaryComponents, "Id", "Id")
            Return View()
        End Function

        ' POST: EmpMonthlyComponets/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,amount,EmpMonthlySalaryId,EmpSalaryComponentId")> ByVal empMonthlyComponet As EmpMonthlyComponet) As ActionResult
            If ModelState.IsValid Then
                db.EmpMonthlyComponets.Add(empMonthlyComponet)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmpMonthlySalaryId = New SelectList(db.EmpMonthlySalaries, "Id", "Id", empMonthlyComponet.EmpMonthlySalaryId)
            ViewBag.EmpSalaryComponentId = New SelectList(db.EmpSalaryComponents, "Id", "Id", empMonthlyComponet.EmpSalaryComponentId)
            Return View(empMonthlyComponet)
        End Function

        ' GET: EmpMonthlyComponets/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empMonthlyComponet As EmpMonthlyComponet = db.EmpMonthlyComponets.Find(id)
            If IsNothing(empMonthlyComponet) Then
                Return HttpNotFound()
            End If
            ViewBag.EmpMonthlySalaryId = New SelectList(db.EmpMonthlySalaries, "Id", "Id", empMonthlyComponet.EmpMonthlySalaryId)
            ViewBag.EmpSalaryComponentId = New SelectList(db.EmpSalaryComponents, "Id", "Id", empMonthlyComponet.EmpSalaryComponentId)
            Return View(empMonthlyComponet)
        End Function

        ' POST: EmpMonthlyComponets/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,amount,EmpMonthlySalaryId,EmpSalaryComponentId")> ByVal empMonthlyComponet As EmpMonthlyComponet) As ActionResult
            If ModelState.IsValid Then
                db.Entry(empMonthlyComponet).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmpMonthlySalaryId = New SelectList(db.EmpMonthlySalaries, "Id", "Id", empMonthlyComponet.EmpMonthlySalaryId)
            ViewBag.EmpSalaryComponentId = New SelectList(db.EmpSalaryComponents, "Id", "Id", empMonthlyComponet.EmpSalaryComponentId)
            Return View(empMonthlyComponet)
        End Function

        ' GET: EmpMonthlyComponets/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empMonthlyComponet As EmpMonthlyComponet = db.EmpMonthlyComponets.Find(id)
            If IsNothing(empMonthlyComponet) Then
                Return HttpNotFound()
            End If
            Return View(empMonthlyComponet)
        End Function

        ' POST: EmpMonthlyComponets/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empMonthlyComponet As EmpMonthlyComponet = db.EmpMonthlyComponets.Find(id)
            db.EmpMonthlyComponets.Remove(empMonthlyComponet)
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
