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
    Public Class EmployerMastsController
        Inherits System.Web.Mvc.Controller

        Private db As New HRP1Entities

        Function GenrateSalary(ByVal CC As Integer?) As ActionResult

            If (db.EmpMonthlySalaries.Where(Function(e) e.WorkingMonthDate.Month = Now.Month And e.WorkingMonthDate.Year = Now.Year).ToList().Count <= 0) Then
                '    Dim leavemast As New LeaveMast
                Dim lwpdays As Int16
                Dim emp = db.EmployeeMasts.Where(Function(e) e.EmployerMast_cc1 = CC)
                Dim lwpid As Int16

                For Each emps As EmployeeMast In emp.ToList()
                    Dim Salary As New EmpMonthlySalary
                    Dim salarycompnet As New EmpMonthlyComponet
                    Dim addamt As Double = 0
                    Dim dedamt As Double = 0
                    Dim empsm As EmployeeSalaryMast = db.EmployeeSalaryMasts.Where(Function(e) e.EmployeeMastId = emps.Id).SortBy("Wfd Desc").First()
                    Dim salarycom = db.View_2.Where(Function(e) e.EmployeeMastId = emps.Id).ToList()
                    lwpid = db.LeaveMasts.Where(Function(e1) e1.EmployerMast_cc = CC And e1.LeaveName = "LWP" And e1.FYMasterFY = empsm.FYMasterFY).FirstOrDefault.Id
                    If db.EmpLeaves.Count() > 0 Then lwpdays = db.EmpLeaves.Where(Function(e) e.EmployeeMastId = emps.Id And e.FromDate.Month = Now.Month And e.FromDate.Year = Now.Year And e.Todate.Month = Now.Month And e.Todate.Year = Now.Year And e.LeaveMastId = lwpid).Sum(Function(e) e.LeaveDays)
                    Salary.WorkingMonthDate = Now
                    Salary.WorkingDays = DateTime.DaysInMonth(Now.Year, Now.Month)
                    Salary.LeaveDays = lwpdays
                    Salary.TotalDays = Salary.WorkingDays - Salary.LeaveDays
                    Salary.TotalSalaryAmount = empsm.CTCMonthly

                    Salary.EmployeeSalaryMastId = empsm.Id
                    db.EmpMonthlySalaries.Add(Salary)
                    db.SaveChanges()
                    Dim empsalarycomp = db.EmpSalaryComponents.Where(Function(e) e.EmployeeSalaryMastId = empsm.Id).ToList()
                    For Each empsc As EmpSalaryComponent In empsalarycomp
                        salarycompnet.EmpMonthlySalaryId = db.EmpMonthlySalaries.OrderByDescending(Function(e) e.Id).FirstOrDefault().Id
                        salarycompnet.amount = empsc.Amount

                        If empsc.SalaryComponentMast.Compcalcutiontype = Addmine.Add Then
                            addamt += empsc.Amount
                        Else
                            dedamt += empsc.Amount
                        End If
                        salarycompnet.EmpSalaryComponentId = empsc.Id
                        db.EmpMonthlyComponets.Add(salarycompnet)
                        db.SaveChanges()
                    Next
                    Salary = db.EmpMonthlySalaries.OrderByDescending(Function(e) e.Id).FirstOrDefault()
                    Salary.OnhandAmount = addamt
                    Salary.Deductamount = dedamt
                    db.Entry(Salary).State = EntityState.Modified
                    db.SaveChanges()
                Next
            End If


            Dim employerMasts = db.EmployerMasts.Include(Function(e) e.FYMaster)
            Return View("Index", employerMasts.ToList())
        End Function
        ' GET: EmployerMasts
        Function Index() As ActionResult
            Dim employerMasts = db.EmployerMasts.Include(Function(e) e.FYMaster)
            Return View(employerMasts.ToList())
        End Function

        ' GET: EmployerMasts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employerMast As EmployerMast = db.EmployerMasts.Find(id)
            If IsNothing(employerMast) Then
                Return HttpNotFound()
            End If
            Return View(employerMast)
        End Function

        ' GET: EmployerMasts/Create
        Function Create() As ActionResult
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY")
            Return View()
        End Function

        ' POST: EmployerMasts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="cc, Name, PANNo, remarks, City, State, Address, Pincode, Emailid, isactive, FYMasterFY")> ByVal employerMast As EmployerMast) As ActionResult
            If ModelState.IsValid Then
                db.EmployerMasts.Add(employerMast)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", employerMast.FYMasterFY)
            Return View(employerMast)
        End Function

        ' GET: EmployerMasts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employerMast As EmployerMast = db.EmployerMasts.Find(id)
            If IsNothing(employerMast) Then
                Return HttpNotFound()
            End If
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", employerMast.FYMasterFY)
            Return View(employerMast)
        End Function

        ' POST: EmployerMasts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="cc, Name, PANNo, remarks, City, State, Address, Pincode, Emailid, isactive, FYMasterFY")> ByVal employerMast As EmployerMast) As ActionResult
            If ModelState.IsValid Then
                db.Entry(employerMast).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.FYMasterFY = New SelectList(db.FYMasters, "FY", "FY", employerMast.FYMasterFY)
            Return View(employerMast)
        End Function

        ' GET: EmployerMasts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employerMast As EmployerMast = db.EmployerMasts.Find(id)
            If IsNothing(employerMast) Then
                Return HttpNotFound()
            End If
            Return View(employerMast)
        End Function

        ' POST: EmployerMasts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim employerMast As EmployerMast = db.EmployerMasts.Find(id)
            db.EmployerMasts.Remove(employerMast)
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
