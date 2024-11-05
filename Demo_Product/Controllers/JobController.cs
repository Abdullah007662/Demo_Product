using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var values = jobManager.TGetList();
            return View(values);
        }
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {
            jobManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteJob(int id)
        {
            var silme = jobManager.TGetById(id);
            jobManager.TDelete(silme);

            return RedirectToAction("Index");
        }
        public IActionResult UpdateJob(int id)
        {
            var Güncelleme = jobManager.TGetById(id);
            return View(Güncelleme);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {

            jobManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
