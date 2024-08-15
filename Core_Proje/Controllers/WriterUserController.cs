using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Core_Proje.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager userManager = new WriterUserManager(new EfWriteUserDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(userManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(WriteUser p)
        {
            userManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }

}
