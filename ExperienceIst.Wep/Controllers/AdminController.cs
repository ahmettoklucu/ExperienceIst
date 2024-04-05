using ExperienceIst.Bussiness.Abstract;
using ExperienceIst.Entities.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExperienceIst.Wep.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRequestService _requestService;
        public AdminController(IRequestService requestService)
        {
            _requestService = requestService;
        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        public JsonResult GetAll()
        {
            var getAll = _requestService.GetAllRequest();
            return Json(getAll);
        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        public JsonResult Get(int id )
        {
            var result = _requestService.GetRequest(id);
            return Json(result);
        }
    }
}
