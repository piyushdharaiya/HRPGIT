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
    Public Class LeaveMastsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: LeaveMasts
        Function Index(ByVal cc As Integer?) As ActionResult
            Dim leaveMasts = db.LeaveMasts.Include(Function(l) l.EmployerMast).Include(Function(l) l.FYMaster).Where(Function(e) e.EmployerMast_cc = cc)
            Return View(leaveMasts.ToList())
        End Function

        ' GET: LeaveMasts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim leaveMast As LeaveMast = db.LeaveMasts.Find(id)
            If IsNothing(leaveMast) Then
                Return HttpNotFound()
            End If
            Return View(leaveMast)
        End Function

        ' GET: LeaveMasts/Create
        Function Create() As ActionResult
            ViewBag.EmployerMast_cc = New SelectList(db.EmployerMasts, "cc", "Name")
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY")
            Return View()
        End Function

        ' POST: LeaveMasts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,LeaveName,NoofDays,wfd,FYMasterFY,EmployerMast_cc")> ByVal leaveMast As LeaveMast) As ActionResult
            If ModelState.IsValid Then
                db.LeaveMasts.Add(leaveMast)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployerMast_cc = New SelectList(db.EmployerMasts, "cc", "Name", leaveMast.EmployerMast_cc)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", leaveMast.FYMasterFY)
            Return View(leaveMast)
        End Function

        ' GET: LeaveMasts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim leaveMast As LeaveMast = db.LeaveMasts.Find(id)
            If IsNothing(leaveMast) Then
                Return HttpNotFound()
            End If
            ViewBag.EmployerMast_cc = New SelectList(db.EmployerMasts, "cc", "Name", leaveMast.EmployerMast_cc)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", leaveMast.FYMasterFY)
            Return View(leaveMast)
        End Function

        ' POST: LeaveMasts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,LeaveName,NoofDays,wfd,FYMasterFY,EmployerMast_cc")> ByVal leaveMast As LeaveMast) As ActionResult
            If ModelState.IsValid Then
                db.Entry(leaveMast).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployerMast_cc = New SelectList(db.EmployerMasts, "cc", "Name", leaveMast.EmployerMast_cc)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", leaveMast.FYMasterFY)
            Return View(leaveMast)
        End Function

        ' GET: LeaveMasts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim leaveMast As LeaveMast = db.LeaveMasts.Find(id)
            If IsNothing(leaveMast) Then
                Return HttpNotFound()
            End If
            Return View(leaveMast)
        End Function

        ' POST: LeaveMasts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim leaveMast As LeaveMast = db.LeaveMasts.Find(id)
            db.LeaveMasts.Remove(leaveMast)
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
