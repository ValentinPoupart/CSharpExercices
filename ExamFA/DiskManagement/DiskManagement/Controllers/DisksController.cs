using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DiskManagement.Models;

namespace DiskManagement.Controllers
{
    public class DisksController : Controller
    {
        private static DiskService _diskService = new DiskService();

        // GET: Disks
        public ActionResult Index(string searchTitleString)
        {
            var disks = _diskService.GetAll();

            if (!String.IsNullOrEmpty(searchTitleString))
            {
                disks = disks.Where(x => x.Titre.Contains(searchTitleString));
            }
            return View(disks.ToList());
        }

        // GET: Disks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disk disk = _diskService.Find(id);
            if (disk == null)
            {
                return HttpNotFound();
            }
            return View(disk);
        }

        // GET: Disks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Titre,Interprete,DateSortie")] Disk disk)
        {
            if (ModelState.IsValid)
            {
                _diskService.Add(disk);
                return RedirectToAction("Index");
            }

            return View(disk);
        }

        // GET: Disks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disk disk = _diskService.Find(id);
            if (disk == null)
            {
                return HttpNotFound();
            }
            return View(disk);
        }

        // POST: Disks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titre,Interprete,DateSortie")] Disk disk)
        {
            if (ModelState.IsValid)
            {
                _diskService.Update(disk);
                return RedirectToAction("Index");
            }
            return View(disk);
        }

        // GET: Disks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disk disk = _diskService.Find(id);
            if (disk == null)
            {
                return HttpNotFound();
            }
            return View(disk);
        }

        // POST: Disks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Disk disk = _diskService.Find(id);
            _diskService.Remove(disk);
            return RedirectToAction("Index");
        }        
    }
}
