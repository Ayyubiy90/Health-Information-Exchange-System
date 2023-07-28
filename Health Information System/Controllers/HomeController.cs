using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using E_HealthCareMVC.Models;

namespace E_HealthCareMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Doctor()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Appointment()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Contact(TblContact tblContact)
        //{
        //    using (AnymalDataEntities entities = new AnymalDataEntities())
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            entities.TblContacts.Add(tblContact);
        //            entities.SaveChanges();
        //            Response.Write("<script>alert('Feedback Send Sucessfully')</script>");
        //            ModelState.Clear();
        //        }
        //    }
        //    return View(tblContact);
        //}
        [HttpPost]
        public ActionResult Registration(TblUser tblRegistration)
        {
            using (HealthDTEntities entities = new HealthDTEntities())
            {
                if (ModelState.IsValid)
                {
                    entities.TblUsers.Add(tblRegistration);
                    entities.SaveChanges();
                    Response.Write("<script>alert('Feedback Send Sucessfully')</script>");
                    ModelState.Clear();
                }
            }
            return View(tblRegistration);
        }
        //[HttpPost]
        //public ActionResult Appointment(TblAppointment tblAppointment)
        //{
        //    using (AnymalDataEntities entities = new AnymalDataEntities())
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            entities.TblAppointments.Add(tblAppointment);
        //            entities.SaveChanges();
        //            Response.Write("<script>alert('Feedback Send Sucessfully')</script>");
        //            ModelState.Clear();
        //        }
        //    }
        //    return View(tblAppointment);

        //}
        [HttpPost]
        public ActionResult Login(TblUser tblRegistration)
        {
            {
                using (HealthDTEntities entities = new HealthDTEntities())
                {
                    var obj = entities.TblUsers.Where(a => a.userName.Equals(tblRegistration.userName) && a.password.Equals(tblRegistration.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        //Session["UserID"] = obj.UserId.ToString();
                        //Session["UserName"] = obj.email.ToString();
                        return RedirectToAction("Contact");
                    }
                }
            }
            return View(tblRegistration);
        }
    }
}