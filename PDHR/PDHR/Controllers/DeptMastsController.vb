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
    Public Class DeptMastsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: DeptMasts
        Function Index() As ActionResult
            Return View(db.DeptMasts.ToList())
        End Function

        ' GET: DeptMasts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim deptMast As DeptMast = db.DeptMasts.Find(id)
            If IsNothing(deptMast) Then
                Return HttpNotFound()
            End If
            Return View(deptMast)
        End Function

        ' GET: DeptMasts/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: DeptMasts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Dept_Name")> ByVal deptMast As DeptMast) As ActionResult
            If ModelState.IsValid Then
                db.DeptMasts.Add(deptMast)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(deptMast)
        End Function

        ' GET: DeptMasts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim deptMast As DeptMast = db.DeptMasts.Find(id)
            If IsNothing(deptMast) Then
                Return HttpNotFound()
            End If
            Return View(deptMast)
        End Function

        ' POST: DeptMasts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Dept_Name")> ByVal deptMast As DeptMast) As ActionResult
            If ModelState.IsValid Then
                db.Entry(deptMast).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(deptMast)
        End Function

        ' GET: DeptMasts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim deptMast As DeptMast = db.DeptMasts.Find(id)
            If IsNothing(deptMast) Then
                Return HttpNotFound()
            End If
            Return View(deptMast)
        End Function

        ' POST: DeptMasts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim deptMast As DeptMast = db.DeptMasts.Find(id)
            db.DeptMasts.Remove(deptMast)
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
