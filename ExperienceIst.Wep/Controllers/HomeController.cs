﻿using ExperienceIst.Bussiness.Abstract;
using ExperienceIst.Entities.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExperienceIst.Wep.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRequestService _requestService;
        public HomeController(IRequestService requestService)
        {
            _requestService = requestService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public  JsonResult MakeRequest(Request model)
        {

            var addedRequest =  _requestService.AddRequest(model);
            if (addedRequest.Success == true)
            {
                return Json(addedRequest.Message);  
            }
            else
            {
                return Json(addedRequest.Message);
            }

        }
        
    }
}
