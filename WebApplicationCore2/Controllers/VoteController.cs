using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCore2.Models.Domain;
using WebApplicationCore2.Models.Repository;

namespace WebApplicationCore2.Controllers
{
    public class VoteController : Controller
    {
        private readonly IParticipantsRepository paticipantsRepository;
        public VoteController(IParticipantsRepository paticipantsRepository)
        {
            this.paticipantsRepository = paticipantsRepository;
        }
        [Authorize]
        [HttpGet]
        public ActionResult Voting()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Voting(GuestResponse resp)
        {
            string partiesName = Request.Cookies["PartiesName"];
            if (resp.Id == default)
            {

            }
            string name = User.Identity.Name;
            paticipantsRepository.Save(name,partiesName);

            return Redirect("/Participants/Participants");
        }
    }
}