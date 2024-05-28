using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
    
        public IActionResult Apply() // bu metot get için çalışır
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //güvenlik için post ve get işlemlerinde
        public IActionResult Apply([FromForm] Candidate model) // bu metot post için çalışır
        {                   // buradan gelecek verinin nereden geleceğini belirttik [FromForm]

            //Bu ifade ile birlikte var olan kayıtların tekrar yapılmasının önüne geçtik
            if(Repository.Applications.Any(c => c.Email!.Equals(model.Email)))
            {
                ModelState.AddModelError("", "There is already an application for you.");
            }

            if(ModelState.IsValid) // Eğer işlem geçerliyse bu işlemi yapmasını sağladık (model doğrulama)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View(); // başarısızsa aynı sayfaya döndük
        }

    }
}