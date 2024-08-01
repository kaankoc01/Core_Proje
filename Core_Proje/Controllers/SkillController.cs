using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager SkillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = SkillManager.TGetList();
            return View(values);
        }
    }
}
