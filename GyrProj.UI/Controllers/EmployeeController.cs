using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GyrProj.Context;
using GyrProj.Models;

namespace GyrProj.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private context db = new context();

        // GET: Employee
        public ActionResult Index()
        {
            //return View(db.Employees.ToList());
            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpMaster empMaster = db.Employees.Find(id);
            if (empMaster == null)
            {
                return HttpNotFound();
            }
            return View(empMaster);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,Education,age,technical_exp,Last_co_worked")] EmpMaster empMaster)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(empMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empMaster);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpMaster empMaster = db.Employees.Find(id);
            if (empMaster == null)
            {
                return HttpNotFound();
            }
            return View(empMaster);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,Education,age,technical_exp,Last_co_worked")] EmpMaster empMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empMaster);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpMaster empMaster = db.Employees.Find(id);
            if (empMaster == null)
            {
                return HttpNotFound();
            }
            return View(empMaster);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpMaster empMaster = db.Employees.Find(id);
            db.Employees.Remove(empMaster);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
