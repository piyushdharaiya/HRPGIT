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
    Public Class EmployeeMastsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        ' GET: EmployeeMasts
        Function Index(ByVal CC As Integer?) As ActionResult
            Dim employeeMasts = db.EmployeeMasts.Include(Function(e) e.DeptMast).Include(Function(e) e.EmpLevel).Include(Function(e) e.EmployerMast).Include(Function(e) e.FYMaster).Where(Function(e) e.EmployerMast_cc1 = CC)
            Return View(employeeMasts.ToList())
        End Function

        ' GET: EmployeeMasts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeMast As EmployeeMast = db.EmployeeMasts.Find(id)
            If IsNothing(employeeMast) Then
                Return HttpNotFound()
            End If
            Return View(employeeMast)
        End Function

        ' GET: EmployeeMasts/Create
        Function Create() As ActionResult
            ViewBag.DeptMastId = New SelectList(db.DeptMasts, "Id", "Dept_Name")
            ViewBag.EmpLevelId = New SelectList(db.EmpLevels, "Id", "LevelName")
            ViewBag.EmployerMast_cc1 = New SelectList(db.EmployerMasts, "cc", "Name")
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY")
            Return View()
        End Function

        ' POST: EmployeeMasts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Fname,MName,Lname,DOB,PANno,UANNo,ESINo,PFNo,JoinofDate,city,State,Address,pinCode,Emailid,BankName,Accountno,IFSCCode,isactive,FYMasterFY,DeptMastId,EmpLevelId,EmployerMast_cc1")> ByVal employeeMast As EmployeeMast) As ActionResult
            If ModelState.IsValid Then
                db.EmployeeMasts.Add(employeeMast)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.DeptMastId = New SelectList(db.DeptMasts, "Id", "Dept_Name", employeeMast.DeptMastId)
            ViewBag.EmpLevelId = New SelectList(db.EmpLevels, "Id", "LevelName", employeeMast.EmpLevelId)
            ViewBag.EmployerMast_cc1 = New SelectList(db.EmployerMasts, "cc", "Name", employeeMast.EmployerMast_cc1)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", employeeMast.FYMasterFY)
            Return View(employeeMast)
        End Function

        ' GET: EmployeeMasts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeMast As EmployeeMast = db.EmployeeMasts.Find(id)
            If IsNothing(employeeMast) Then
                Return HttpNotFound()
            End If
            ViewBag.DeptMastId = New SelectList(db.DeptMasts, "Id", "Dept_Name", employeeMast.DeptMastId)
            ViewBag.EmpLevelId = New SelectList(db.EmpLevels, "Id", "LevelName", employeeMast.EmpLevelId)
            ViewBag.EmployerMast_cc1 = New SelectList(db.EmployerMasts, "cc", "Name", employeeMast.EmployerMast_cc1)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", employeeMast.FYMasterFY)
            Return View(employeeMast)
        End Function

        ' POST: EmployeeMasts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Fname,MName,Lname,DOB,PANno,UANNo,ESINo,PFNo,JoinofDate,city,State,Address,pinCode,Emailid,BankName,Accountno,IFSCCode,isactive,FYMasterFY,DeptMastId,EmpLevelId,EmployerMast_cc1")> ByVal employeeMast As EmployeeMast) As ActionResult
            If ModelState.IsValid Then
                db.Entry(employeeMast).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.DeptMastId = New SelectList(db.DeptMasts, "Id", "Dept_Name", employeeMast.DeptMastId)
            ViewBag.EmpLevelId = New SelectList(db.EmpLevels, "Id", "LevelName", employeeMast.EmpLevelId)
            ViewBag.EmployerMast_cc1 = New SelectList(db.EmployerMasts, "cc", "Name", employeeMast.EmployerMast_cc1)
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", employeeMast.FYMasterFY)
            Return View(employeeMast)
        End Function

        ' GET: EmployeeMasts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeMast As EmployeeMast = db.EmployeeMasts.Find(id)
            If IsNothing(employeeMast) Then
                Return HttpNotFound()
            End If
            Return View(employeeMast)
        End Function

        ' POST: EmployeeMasts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim employeeMast As EmployeeMast = db.EmployeeMasts.Find(id)
            db.EmployeeMasts.Remove(employeeMast)
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
