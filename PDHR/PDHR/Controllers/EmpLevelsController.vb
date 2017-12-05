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
    Public Class EmpLevelsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: EmpLevels
        Function Index() As ActionResult
            Return View(db.EmpLevels.ToList())
        End Function

        ' GET: EmpLevels/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empLevel As EmpLevel = db.EmpLevels.Find(id)
            If IsNothing(empLevel) Then
                Return HttpNotFound()
            End If
            Return View(empLevel)
        End Function

        ' GET: EmpLevels/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: EmpLevels/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,LevelName,wfd")> ByVal empLevel As EmpLevel) As ActionResult
            If ModelState.IsValid Then
                db.EmpLevels.Add(empLevel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(empLevel)
        End Function

        ' GET: EmpLevels/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empLevel As EmpLevel = db.EmpLevels.Find(id)
            If IsNothing(empLevel) Then
                Return HttpNotFound()
            End If
            Return View(empLevel)
        End Function

        ' POST: EmpLevels/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,LevelName,wfd")> ByVal empLevel As EmpLevel) As ActionResult
            If ModelState.IsValid Then
                db.Entry(empLevel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(empLevel)
        End Function

        ' GET: EmpLevels/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empLevel As EmpLevel = db.EmpLevels.Find(id)
            If IsNothing(empLevel) Then
                Return HttpNotFound()
            End If
            Return View(empLevel)
        End Function

        ' POST: EmpLevels/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empLevel As EmpLevel = db.EmpLevels.Find(id)
            db.EmpLevels.Remove(empLevel)
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
