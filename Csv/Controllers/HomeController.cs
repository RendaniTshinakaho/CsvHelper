using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Csv.Models;
using CsvHelper;

namespace Csv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            string path = null;
            var carDisplays = new List<CarDisplay>();
            try
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    path = AppDomain.CurrentDomain.BaseDirectory + "upload\\" + fileName;
                    file.SaveAs(path);
                    using (var sr = new StreamReader(path))
                    {
                        var csv = new CsvReader(sr);
                        var clientList = csv.GetRecords<Car>().ToList();

                        foreach (var c in clientList)
                        {
                            var carDisplay = new CarDisplay();
                            carDisplay.Code = c.Code;
                            carDisplay.BodyStyle = c.BodyStyle;
                            carDisplay.Engine = c.Engine;
                            carDisplay.Derivative = c.Derivative;
                            carDisplay.ModelCode = c.ModelCode;
                            carDisplay.TrimLevel = c.TrimLevel;
                            carDisplay.DerivativeParkCode = c.DerivativeParkCode;
                            carDisplay.CountryCode = c.CountryCode;
                            carDisplay.ModelAvailabilty = c.ModelAvailabilty;
                            carDisplay.ImporterPrice = double.Parse(c.ImporterPrice);
                            carDisplay.Freight = c.Freight;
                            carDisplay.Insurance = c.Insurance;

                            carDisplays.Add(carDisplay);
                        } 
                    }
                }
            }
            catch
            {
                ViewData["error"] = "UploadFailed";
            }
            return View(carDisplays);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}