using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize (Roles ="admin")]
    public class DoctorsController : Controller
    {
        // GET: Doctors
        HospitalContext hc1 = new HospitalContext();
        public ActionResult Index()
        {

            List<Doctor> dtlist = hc1.doctor.ToList();
            return View(dtlist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Doctor dc)
        {
            if (ModelState.IsValid)
            {
                hc1.doctor.Add(dc);
                hc1.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View(hc1.doctor.Find(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            Doctor dc = hc1.doctor.Find(id);
            hc1.doctor.Remove(dc);
            hc1.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int id)
        {
            return View(hc1.doctor.Find(id));
        }
        [HttpPost]
        
        public ActionResult Edit(Doctor dc)
        {
            if(ModelState.IsValid)
            {
                hc1.Entry(dc).State = System.Data.Entity.EntityState.Modified;
                hc1.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View(hc1);
        }
        } 

    }
