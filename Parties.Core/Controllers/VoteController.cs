using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parties.Core.Models;


namespace Parties.Core.Controllers
{
    public class VoteController : Controller
    {
        private readonly ParticipantsRepository paticipantsRepository;
        public VoteController(ParticipantsRepository paticipantsRepository)
        {
            this.paticipantsRepository = paticipantsRepository;
        }
        [HttpGet]
        public ActionResult Voting()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Voting(GuestResponse resp, Models.Parties partiesResp)
        {
            Response.Cookies.Append("PartiesName", partiesResp.PartiesName);

            paticipantsRepository.Save(resp);

            return Redirect("/Participants/Participants");
        }
    }
}