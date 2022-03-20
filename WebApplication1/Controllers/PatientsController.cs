using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PatientsController : Controller
    {
        HospitalContext hc = new HospitalContext();

        // GET: Patients
        public ActionResult Index()
        {
            List<Patient> ptlist = hc.patient.ToList();
            return View(ptlist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Patient pt)
        {
            if (ModelState.IsValid)
            {
                hc.patient.Add(pt);
                hc.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            // return View(hc.patient.Single<>)
            return View(hc.patient.Find(id));

        }
        public ActionResult Edit(Patient dc)
        {
            if (ModelState.IsValid)
            {
                hc.Entry(dc).State = System.Data.Entity.EntityState.Modified;
                hc.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View(hc);
        }
        public ActionResult Details(int id)
        {
            
            return View(hc.patient.Find(id));

        }
        public ActionResult Delete(int id)
        {
            return View(hc.patient.Find(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            Patient pt = hc.patient.Find(id);
            hc.patient.Remove(pt);
            hc.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}