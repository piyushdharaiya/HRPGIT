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
    Public Class EmpSalaryComponentsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities
        Function GetComponetAmount(ByVal EmployeeSalaryMastId As Int16, ByVal componetid As Int16) As Double
            Dim amount As Double
            Dim EmployeeMastId = db.EmployeeSalaryMasts.Where(Function(e) e.Id = EmployeeSalaryMastId).FirstOrDefault.EmployeeMastId
            Dim ctc = db.EmployeeSalaryMasts.Where(Function(e) e.Id = EmployeeSalaryMastId).FirstOrDefault.CTCMonthly
            Dim typereper = db.SalaryComponentMasts.Where(Function(e) e.Id = componetid).FirstOrDefault.TypeRsPer
            Dim val = db.SalaryComponentMasts.Where(Function(e) e.Id = componetid).FirstOrDefault.amount
            Dim basedon = db.SalaryComponentMasts.Where(Function(e) e.Id = componetid).FirstOrDefault.basedoncomponent
            If typereper = TypePerRs.Rs Then
                amount = val
            Else
                'on CTC
                If basedon = -1 Then
                    amount = ctc * val / 100
                Else
                    'on Bascie
                    amount = GetComponetAmount(EmployeeSalaryMastId, basedon) * val / 100
                End If
            End If

            Return amount
        End Function
        ' GET: EmpSalaryComponents
        Function Index(ByVal id As Integer?) As ActionResult
            Dim empSalaryComponents = db.EmpSalaryComponents.Include(Function(e) e.EmployeeSalaryMast).Include(Function(e) e.SalaryComponentMast).Where(Function(e) e.EmployeeSalaryMastId = id)
            Return View(empSalaryComponents.ToList())
        End Function

        ' GET: EmpSalaryComponents/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empSalaryComponent As EmpSalaryComponent = db.EmpSalaryComponents.Find(id)
            If IsNothing(empSalaryComponent) Then
                Return HttpNotFound()
            End If
            Return View(empSalaryComponent)
        End Function

        ' GET: EmpSalaryComponents/Create
        Function Create() As ActionResult
            ViewBag.EmployeeSalaryMastId = New SelectList(db.EmployeeSalaryMasts, "Id", "FYMasterFY")
            ViewBag.SalaryComponentMastId = New SelectList(db.SalaryComponentMasts, "Id", "Name")
            Return View()
        End Function

        ' POST: EmpSalaryComponents/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Amount,EmployeeSalaryMastId,SalaryComponentMastId")> ByVal empSalaryComponent As EmpSalaryComponent) As ActionResult
            If ModelState.IsValid Then
                empSalaryComponent.Amount = GetComponetAmount(empSalaryComponent.EmployeeSalaryMastId, empSalaryComponent.SalaryComponentMastId)
                db.EmpSalaryComponents.Add(empSalaryComponent)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployeeSalaryMastId = New SelectList(db.EmployeeSalaryMasts, "Id", "FYMasterFY", empSalaryComponent.EmployeeSalaryMastId)
            ViewBag.SalaryComponentMastId = New SelectList(db.SalaryComponentMasts, "Id", "Name", empSalaryComponent.SalaryComponentMastId)
            Return View(empSalaryComponent)
        End Function

        ' GET: EmpSalaryComponents/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empSalaryComponent As EmpSalaryComponent = db.EmpSalaryComponents.Find(id)
            If IsNothing(empSalaryComponent) Then
                Return HttpNotFound()
            End If
            ViewBag.EmployeeSalaryMastId = New SelectList(db.EmployeeSalaryMasts, "Id", "FYMasterFY", empSalaryComponent.EmployeeSalaryMastId)
            ViewBag.SalaryComponentMastId = New SelectList(db.SalaryComponentMasts, "Id", "Name", empSalaryComponent.SalaryComponentMastId)
            Return View(empSalaryComponent)
        End Function

        ' POST: EmpSalaryComponents/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Amount,EmployeeSalaryMastId,SalaryComponentMastId")> ByVal empSalaryComponent As EmpSalaryComponent) As ActionResult
            If ModelState.IsValid Then
                empSalaryComponent.Amount = GetComponetAmount(empSalaryComponent.EmployeeSalaryMastId, empSalaryComponent.SalaryComponentMastId)
                db.Entry(empSalaryComponent).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployeeSalaryMastId = New SelectList(db.EmployeeSalaryMasts, "Id", "FYMasterFY", empSalaryComponent.EmployeeSalaryMastId)
            ViewBag.SalaryComponentMastId = New SelectList(db.SalaryComponentMasts, "Id", "Name", empSalaryComponent.SalaryComponentMastId)
            Return View(empSalaryComponent)
        End Function

        ' GET: EmpSalaryComponents/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empSalaryComponent As EmpSalaryComponent = db.EmpSalaryComponents.Find(id)
            If IsNothing(empSalaryComponent) Then
                Return HttpNotFound()
            End If
            Return View(empSalaryComponent)
        End Function

        ' POST: EmpSalaryComponents/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empSalaryComponent As EmpSalaryComponent = db.EmpSalaryComponents.Find(id)
            db.EmpSalaryComponents.Remove(empSalaryComponent)
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
