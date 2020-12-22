﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers.NewAbilityController
{
    public class NewAbilityController : Controller
    {
        Context context = new Context();
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public JsonResult NewAbility(Models.Abilities ability)
        {
            context.ABILITY.Add(ability);
            context.SaveChanges();
            return Json("başarılı");
        }
    }
}
