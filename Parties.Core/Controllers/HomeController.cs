using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Parties.Core.Models;

namespace Parties.Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly PartiesRepository partiesRepository;
        public HomeController(PartiesRepository partiesRepository)
        {
            this.partiesRepository = partiesRepository;
        }
        public ActionResult Index()
        {
            var model = partiesRepository.GetParties();
            return View(model);

        }
    }
}