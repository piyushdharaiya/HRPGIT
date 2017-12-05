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
    Public Class EmpLeavesController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: EmpLeaves
        Function Index(ByVal id As Integer?) As ActionResult
            Dim empLeaves = db.EmpLeaves.Include(Function(e) e.EmployeeMast).Include(Function(e) e.LeaveMast).Where(Function(e) e.EmployeeMastId = id)
            Return View(empLeaves.ToList())
        End Function

        ' GET: EmpLeaves/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empLeaf As EmpLeaf = db.EmpLeaves.Find(id)
            If IsNothing(empLeaf) Then
                Return HttpNotFound()
            End If
            Return View(empLeaf)
        End Function

        ' GET: EmpLeaves/Create
        Function Create() As ActionResult
            ViewBag.EmployeeMastId = New SelectList(db.EmployeeMasts, "Id", "Fname")
            ViewBag.LeaveMastId = New SelectList(db.LeaveMasts, "Id", "LeaveName")
            Return View()
        End Function

        ' POST: EmpLeaves/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,FromDate,Todate,Remarks,LeaveDays,LeaveStatus,EmployeeMastId,LeaveMastId")> ByVal empLeaf As EmpLeaf) As ActionResult
            If ModelState.IsValid Then
                db.EmpLeaves.Add(empLeaf)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployeeMastId = New SelectList(db.EmployeeMasts, "Id", "Fname", empLeaf.EmployeeMastId)
            ViewBag.LeaveMastId = New SelectList(db.LeaveMasts, "Id", "LeaveName", empLeaf.LeaveMastId)
            Return View(empLeaf)
        End Function

        ' GET: EmpLeaves/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empLeaf As EmpLeaf = db.EmpLeaves.Find(id)
            If IsNothing(empLeaf) Then
                Return HttpNotFound()
            End If
            ViewBag.EmployeeMastId = New SelectList(db.EmployeeMasts, "Id", "Fname", empLeaf.EmployeeMastId)
            ViewBag.LeaveMastId = New SelectList(db.LeaveMasts, "Id", "LeaveName", empLeaf.LeaveMastId)
            Return View(empLeaf)
        End Function

        ' POST: EmpLeaves/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,FromDate,Todate,Remarks,LeaveDays,LeaveStatus,EmployeeMastId,LeaveMastId")> ByVal empLeaf As EmpLeaf) As ActionResult
            If ModelState.IsValid Then
                db.Entry(empLeaf).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployeeMastId = New SelectList(db.EmployeeMasts, "Id", "Fname", empLeaf.EmployeeMastId)
            ViewBag.LeaveMastId = New SelectList(db.LeaveMasts, "Id", "LeaveName", empLeaf.LeaveMastId)
            Return View(empLeaf)
        End Function

        ' GET: EmpLeaves/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empLeaf As EmpLeaf = db.EmpLeaves.Find(id)
            If IsNothing(empLeaf) Then
                Return HttpNotFound()
            End If
            Return View(empLeaf)
        End Function

        ' POST: EmpLeaves/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empLeaf As EmpLeaf = db.EmpLeaves.Find(id)
            db.EmpLeaves.Remove(empLeaf)
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
