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
    Public Class SalaryComponentMastsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: SalaryComponentMasts
        Function Index() As ActionResult
            Return View(db.SalaryComponentMasts.ToList())
        End Function

        ' GET: SalaryComponentMasts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim salaryComponentMast As SalaryComponentMast = db.SalaryComponentMasts.Find(id)
            If IsNothing(salaryComponentMast) Then
                Return HttpNotFound()
            End If
            Return View(salaryComponentMast)
        End Function

        ' GET: SalaryComponentMasts/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: SalaryComponentMasts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,wfd,Name,CompType,TypeRsPer,amount,basedoncomponent,Compcalcutiontype")> ByVal salaryComponentMast As SalaryComponentMast) As ActionResult
            If ModelState.IsValid Then
                db.SalaryComponentMasts.Add(salaryComponentMast)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(salaryComponentMast)
        End Function

        ' GET: SalaryComponentMasts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim salaryComponentMast As SalaryComponentMast = db.SalaryComponentMasts.Find(id)
            If IsNothing(salaryComponentMast) Then
                Return HttpNotFound()
            End If
            Return View(salaryComponentMast)
        End Function

        ' POST: SalaryComponentMasts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,wfd,Name,CompType,TypeRsPer,amount,basedoncomponent,Compcalcutiontype")> ByVal salaryComponentMast As SalaryComponentMast) As ActionResult
            If ModelState.IsValid Then
                db.Entry(salaryComponentMast).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(salaryComponentMast)
        End Function

        ' GET: SalaryComponentMasts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim salaryComponentMast As SalaryComponentMast = db.SalaryComponentMasts.Find(id)
            If IsNothing(salaryComponentMast) Then
                Return HttpNotFound()
            End If
            Return View(salaryComponentMast)
        End Function

        ' POST: SalaryComponentMasts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim salaryComponentMast As SalaryComponentMast = db.SalaryComponentMasts.Find(id)
            db.SalaryComponentMasts.Remove(salaryComponentMast)
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
