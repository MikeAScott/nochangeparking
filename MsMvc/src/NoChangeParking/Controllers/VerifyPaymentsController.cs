using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NoChangeParking.Models;

namespace NoChangeParking.Controllers
{
    public class VerifyPaymentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: VerifyPayments/Create
        public ActionResult Check()
        {
            return View();
        }

        // POST: VerifyPayments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Check([Bind(Include = "Id,RegistrationPlate")] VerifyPayments verifyPayments)
        {
            if (!ModelState.IsValid)
                return View(verifyPayments);
            var checkReg=CleanReg(verifyPayments.RegistrationPlate);
            PaymentDetails payment=db.PaymentDetails.FirstOrDefault(
                    p => p.RegistrationPlate.ToUpper().Replace(" ", "").Replace("-", "") == checkReg
                );
            var response=new VerifyPayments();
            if (payment == null)
                    response.InValidStatusMessage = checkReg + " HAS NOT PAID!!!";
            else
                    response.ValidStatusMessage = checkReg + " has paid";
            ModelState.Clear();
            return View(response);
        }

        private static String CleanReg(String reg)
        {
            return reg.ToUpper().Replace(" ", "").Replace("-", "");
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
