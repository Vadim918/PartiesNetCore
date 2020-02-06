using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Parties.Core.Models;

namespace Parties.Core.Controllers
{
    public class ParticipantsController : Controller
    {
        private readonly ParticipantsRepository paticipantsRepository;
        public ParticipantsController(ParticipantsRepository paticipantsRepository)
        {
            this.paticipantsRepository = paticipantsRepository;
        }
        public ActionResult Participants()            
        { 
            string partiesName = Request.Cookies["PartiesName"];
            Repository.AddParties(partiesName);
            return View(*paticipantsRepository.Read(partiesName));
        }
    }
   
}