using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCore2.Models.Domain;
using WebApplicationCore2.Models.Repository;

namespace WebApplicationCore2.Controllers
{
    public class ParticipantsController : Controller
    {
        private readonly IParticipantsRepository paticipantsRepository;
        public ParticipantsController(IParticipantsRepository paticipantsRepository)
        {
            this.paticipantsRepository = paticipantsRepository;
        }
        public ActionResult Participants()
        {
            string partiesName = Request.Cookies["PartiesName"];
            LayoutRepository.AddParties(partiesName);
            return View(paticipantsRepository.Read(partiesName));
        }
    }
}