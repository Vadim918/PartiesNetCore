using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCore2.Models;
using WebApplicationCore2.Models.Domain;
using WebApplicationCore2.Models.Repository;

namespace WebApplicationCore2.Controllers
{
    public class HomeController : Controller
    {
        private IPartiesRepository partiesRepository;
        public HomeController(IPartiesRepository partiesRepository)
        {
            this.partiesRepository = partiesRepository;
        }
        public ActionResult Index()
        {
            var model = partiesRepository.GetParties();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(PartiesResponse partiesResp)
        {
            Response.Cookies.Append("PartiesName", partiesResp.PartiesName);

            return Redirect("Vote/voting");

        }
    }
}
