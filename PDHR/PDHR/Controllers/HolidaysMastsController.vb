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
    Public Class HolidaysMastsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: HolidaysMasts
        Function Index(ByVal CC As Integer?) As ActionResult
            Dim holidaysMasts = db.HolidaysMasts.Include(Function(h) h.EmployerMast).Include(Function(h) h.FYMaster).Where(Function(e) e.EmployerMast_cc = CC)
            Return View(holidaysMasts.ToList())
        End Function

        ' GET: HolidaysMasts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim holidaysMast As HolidaysMast = db.HolidaysMasts.Find(id)
            If IsNothing(holidaysMast) Then
                Return HttpNotFound()
            End If
            Return View(holidaysMast)
        End Function

        ' GET: HolidaysMasts/Create
        Function Create() As ActionResult
            ViewBag.EmployerMast_cc = New SelectList(db.EmployerMasts, "cc", "Name")
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY")
            Return View()
        End Function

        ' POST: HolidaysMasts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,HolidaysName,HolidaysDate,wfd,FYMasterFY,EmployerMast_cc")> ByVal holidaysMast As HolidaysMast) As ActionResult
            If ModelState.IsValid Then
                db.HolidaysMasts.Add(holidaysMast)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployerMast_cc = New SelectList(db.EmployerMasts, "cc", "Name", holidaysMast.EmployerMast_cc)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", holidaysMast.FYMasterFY)
            Return View(holidaysMast)
        End Function

        ' GET: HolidaysMasts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim holidaysMast As HolidaysMast = db.HolidaysMasts.Find(id)
            If IsNothing(holidaysMast) Then
                Return HttpNotFound()
            End If
            ViewBag.EmployerMast_cc = New SelectList(db.EmployerMasts, "cc", "Name", holidaysMast.EmployerMast_cc)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", holidaysMast.FYMasterFY)
            Return View(holidaysMast)
        End Function

        ' POST: HolidaysMasts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,HolidaysName,HolidaysDate,wfd,FYMasterFY,EmployerMast_cc")> ByVal holidaysMast As HolidaysMast) As ActionResult
            If ModelState.IsValid Then
                db.Entry(holidaysMast).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployerMast_cc = New SelectList(db.EmployerMasts, "cc", "Name", holidaysMast.EmployerMast_cc)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", holidaysMast.FYMasterFY)
            Return View(holidaysMast)
        End Function

        ' GET: HolidaysMasts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim holidaysMast As HolidaysMast = db.HolidaysMasts.Find(id)
            If IsNothing(holidaysMast) Then
                Return HttpNotFound()
            End If
            Return View(holidaysMast)
        End Function

        ' POST: HolidaysMasts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim holidaysMast As HolidaysMast = db.HolidaysMasts.Find(id)
            db.HolidaysMasts.Remove(holidaysMast)
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
