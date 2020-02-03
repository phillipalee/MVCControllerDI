using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCControllerDI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVCControllerDI.Controllers
{
    public class ThingsController : Controller
    {
        private IRecordRepo _recordRepo;
        private ILogger _logger;

        public ThingsController(IRecordRepo repo, ILogger<ThingsController> logger)
        {
            _recordRepo = repo;
            _logger = logger;
            
            
        }
        public IActionResult Index()
        {
            var records = _recordRepo.GetRecords();
            var model = new ThingsModel { Things = records };

            _logger.LogInformation("in index now said spiderman");

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