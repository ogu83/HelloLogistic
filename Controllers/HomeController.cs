using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using helloLogistic.Models;

namespace helloLogistic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Initialize()
        {
            var boxesModel = new List<Box>();            
            using (var db = new ShippingContext())
            {                
                db.Boxes.RemoveRange(db.Boxes);
                db.Boxes.Add(new Box{BoxId = 123450, Weight = 3});
                db.Boxes.Add(new Box{BoxId = 123461, Weight = 8});
                db.Boxes.Add(new Box{BoxId = 123472, Weight = 11});
                db.Boxes.Add(new Box{BoxId = 123483, Weight = 3});
                db.Boxes.Add(new Box{BoxId = 123494, Weight = 13});
                db.SaveChanges();
                boxesModel = db.Boxes.ToList();
            }
            return View(boxesModel);
        }

        private int CalculateCost(int Weight)
        {
            return 50 + 7 * Weight;
        }

        public IActionResult CalculatePartCounts()
        {
            var boxesModel = new List<Box>();
            using (var db = new ShippingContext())
            {
                var orderedBoxes = db.Boxes.OrderBy(b => b.Weight);
                var partCount = 1;
                foreach(var box in orderedBoxes) 
                {
                    box.PartCount = ++partCount;
                }
                db.SaveChanges();
                boxesModel = db.Boxes.ToList();
            }
            return View(boxesModel);
        }

        public IActionResult CalculatePartDetails()
        {
            PartsModel partsModel;
            using (var db = new ShippingContext())
            {
                db.Parts.RemoveRange(db.Parts);
                foreach(var box in db.Boxes) 
                {
                    var W = box.Weight;
                    var PC = box.PartCount;
                    var floor = (int)(W / PC);
                    var mod = W % PC;
                    for (var p = 0; p < PC; p++)
                    {
                        var part = new Part
                        {
                            BoxId = box.BoxId,
                            PartWeight = p == 0 ? floor + mod : floor
                        };
                        part.PartCost = CalculateCost(part.PartWeight);
                        db.Parts.Add(part);
                    }
                }
                db.SaveChanges();
                partsModel = new PartsModel { Parts = db.Parts.OrderBy(p => p.BoxId).ToList() };
            }
            return View(partsModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}