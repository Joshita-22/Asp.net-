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
    }
}