using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bookstore.Models;
namespace Bookstore.Controllers
{
    public class OrdersController : Controller
    {
        private pubsEntities db = new pubsEntities();

        // GET: request2
        public ActionResult Index()
        {
            
            var sales = db.sales.Include(s => s.store).Include(s => s.title);
            
            return View(sales.ToList());
        }

        
        [HttpPost]
        public ActionResult Index(string startDate, string endDate, string storeName)
        {

            var sales = db.sales.Include(s => s.store).Include(s => s.title).ToList();

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

            dateFrom = Convert.ToDateTime(startDate);
            dateTo = Convert.ToDateTime(endDate);



            dateFrom = DateTime.Parse(startDate);

            dateTo = DateTime.Parse(endDate);

            if (dateFrom == dateTo || dateFrom > dateTo)
            {
                TempData["errormsg"] = "<script>alert('There is an error in dates.Probably the start date is later than end date or the two dates are similar or you inserted an illogical date,for example 09/10/1000');</script>";
                return View();
            }
            else
            {
                if (storeName.Equals(""))
                {
                    nullTextBoxCounter++;
                    if (nullTextBoxCounter > 1)
                    {
                        TempData["errormsg"] = "<script>alert('Error:You left more than one fields empty.Please fill at least two fields');</script>";
                        return View();
                    }
                    else
                    {

                        sales = sales.FindAll(d => d.ord_date >= dateFrom);
                        sales = sales.FindAll(d => d.ord_date <= dateTo);
                        return View(sales);

                    }
                }
                else
                {
                    if (nullTextBoxCounter > 1)
                    {
                        TempData["errormsg"] = "<script>alert('Error:You left more than one fields empty.Please fill at least two fields');</script>";
                        return View();
                    }
                    else
                    {

                        sales = sales.FindAll(d => d.ord_date >= dateFrom);
                        sales = sales.FindAll(d => d.ord_date <= dateTo);

                        sales = sales.FindAll(s => s.store.stor_name == storeName);

                        return View(sales);



                    }
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