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
    Public Class FYMastersController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: FYMasters
        Function Index() As ActionResult
            Return View(db.FYMasters.ToList())
        End Function

        ' GET: FYMasters/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim fYMaster As FYMaster = db.FYMasters.Find(id)
            If IsNothing(fYMaster) Then
                Return HttpNotFound()
            End If
            Return View(fYMaster)
        End Function

        ' GET: FYMasters/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: FYMasters/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="FY")> ByVal fYMaster As FYMaster) As ActionResult
            If ModelState.IsValid Then
                db.FYMasters.Add(fYMaster)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(fYMaster)
        End Function

        ' GET: FYMasters/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim fYMaster As FYMaster = db.FYMasters.Find(id)
            If IsNothing(fYMaster) Then
                Return HttpNotFound()
            End If
            Return View(fYMaster)
        End Function

        ' POST: FYMasters/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="FY")> ByVal fYMaster As FYMaster) As ActionResult
            If ModelState.IsValid Then
                db.Entry(fYMaster).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(fYMaster)
        End Function

        ' GET: FYMasters/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim fYMaster As FYMaster = db.FYMasters.Find(id)
            If IsNothing(fYMaster) Then
                Return HttpNotFound()
            End If
            Return View(fYMaster)
        End Function

        ' POST: FYMasters/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim fYMaster As FYMaster = db.FYMasters.Find(id)
            db.FYMasters.Remove(fYMaster)
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
