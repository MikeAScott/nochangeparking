using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NoChangeParking.Models;
using NoChangeParking.WorldPayClient;

namespace NoChangeParking.Controllers
{
    public class PaymentDetailsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PaymentDetails
        public ActionResult Index()
        {
            return View(db.PaymentDetails.ToList());
        }

        // GET: PaymentDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentDetails paymentDetails = db.PaymentDetails.Find(id);
            if (paymentDetails == null)
            {
                return HttpNotFound();
            }
            return View(paymentDetails);
        }

        // GET: PaymentDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RegistrationPlate,NameOnCard,CardType,CardNumber,CardExpiry,CardCVCNumeber,CardIssueNumeber")] PaymentDetails paymentDetails)
        {
            if (ModelState.IsValid)
            {
                paymentDetails.RegistrationPlate = paymentDetails.RegistrationPlate.ToUpper();
                paymentDetails.NameOnCard = paymentDetails.NameOnCard.ToUpper();
                paymentDetails.CardNumber = paymentDetails.CardNumber.Replace(" ", "");

                var response=CallWorldPay(paymentDetails);
                if (response.Status=="Paid")
                {
                    paymentDetails.PaymentReference=response.PaymentReference;
                    //paymentDetails.CardCVCNumeber=null;
                    db.PaymentDetails.Add(paymentDetails);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("CardNumber", response.Message);
                    return View(paymentDetails);
                }
            }

            return View(paymentDetails);
        }

        private PaymentResponse CallWorldPay(PaymentDetails paymentDetails)
        {
            var client=new WorldPayGatewayClient();
            return client.MakePayment(paymentDetails);
        }

        // GET: PaymentDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentDetails paymentDetails = db.PaymentDetails.Find(id);
            if (paymentDetails == null)
            {
                return HttpNotFound();
            }
            return View(paymentDetails);
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
