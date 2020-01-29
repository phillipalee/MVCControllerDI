using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCControllerDI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCControllerDI.Controllers
{
    public class ThingsController : Controller
    {
        private IRecordRepo _recordRepo;

        public ThingsController(IRecordRepo repo)
        {
            _recordRepo = repo;
        }
        public IActionResult Index()
        {
            var records = _recordRepo.GetRecords();
            var model = new ThingsModel { Things = records };

            if (records.Count() > 0)
            {
                model.response = "Some stuff";
            }
            else
            {
                model.response = "No stuff";
            }
            return View("Things", model);
        }
    }
}