using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookstore.Controllers
{
    public class ContactInfoController : Controller
    {

        private pubsEntities db = new pubsEntities();
        // GET: ContactInfo
        public ActionResult Index()
        {
            return View(db.authors.ToList());
        }

        

        [HttpPost]
        public ActionResult Index(int? numberX,string startDate, string endDate)
        {
            int nullTextBoxCounter = 0;

            DateTime dateFrom;
            DateTime dateTo;

            if (startDate == "")
            {
                startDate = "01/01/1000";
                nullTextBoxCounter++;

            }

            if (endDate == "")
            {
                nullTextBoxCounter++;
                endDate = "01/01/5000";
            }
            

            dateFrom = DateTime.Parse(startDate);

            dateTo = DateTime.Parse(endDate);

            if (dateFrom == dateTo || dateFrom > dateTo)
            {
                TempData["errormsg"] = "<script>alert('There is an error in dates.Probably the start date is later than end date or the two dates are similar or you inserted an illogical date,for example 09/10/1000');</script>";
                return View();
            }
            else
            {
                var sales = db.sales.ToList();

                sales = sales.OrderByDescending(q => q.qty).ToList();
                sales = sales.FindAll(d => d.ord_date >= dateFrom);
                sales = sales.FindAll(d => d.ord_date <= dateTo);

                if (numberX == null)
                {
                    nullTextBoxCounter++;
                    
                }

                sales = sales.Take(numberX.GetValueOrDefault()).ToList();
                



                var titleauthors = db.titleauthors.ToList();
                var authors = db.authors.ToList();


                titleauthors = titleauthors.Where(id => sales.Any(i => i.title_id == id.title_id)).ToList();
                authors = authors.Where(id => titleauthors.Any(i => i.au_id == id.au_id)).ToList();


                if (nullTextBoxCounter > 1)
                {
                    TempData["errormsg"] = "<script>alert('Error:You left more than one fields empty.Please fill at least two fields');</script>";
                    return View();
                }
                else
                {
                    return View(authors);
                }
            }

            
            

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