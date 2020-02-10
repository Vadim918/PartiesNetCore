using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCore2.Models.Domain;

namespace WebApplicationCore2.Controllers
{
    public class PartiesController : Controller
    {
        private IPartiesRepository partiesRepository;
        public PartiesController(IPartiesRepository partiesRepository)
        {
            this.partiesRepository = partiesRepository;
        }
        [Authorize]
        public IActionResult AllParties()
        {
            var model = partiesRepository.GetParties();
            return View(model);
        }

        [Authorize(Roles = "admin")]
        public IActionResult PartiesEdit(int id)
        {
            //либо создаем новую статью, либо выбираем существующую и передаем в качестве модели в представление
            PartiesResponse model = id == default ? new PartiesResponse() : partiesRepository.GetById(id);
            return View(model);
        }
        [HttpPost] //в POST-версии метода сохраняем/обновляем запись в БД
        public IActionResult PartiesEdit(PartiesResponse model)
        {
            if (ModelState.IsValid)
            {
                partiesRepository.Save(model);
                return RedirectToAction("AllParties");
            }
            return View(model);
        }
    }
}