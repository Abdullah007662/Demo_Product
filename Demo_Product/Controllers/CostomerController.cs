using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo_Product.Controllers
{
    public class CostomerController : Controller
    {
        CostomerManager costomerManager = new CostomerManager(new EfCostomerDal());
        public IActionResult Index()
        {
            var value = costomerManager.GetCostomersListWith();
            return View(value);
        }
        public IActionResult AddCostomer()
        {
            JobManager jobManager = new JobManager(new EfJobDal());
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text =x.Name,
                                               Value = x.JobID.ToString()

                                           }).ToList();
            ViewBag. v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddCostomer( Costomer c)
        {
            costomerManager.TInsert(c);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCostomer(int id)
        {
            var value = costomerManager.TGetById(id);
            costomerManager.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateCostomer(int id)
        {
            JobManager jobManager = new JobManager(new EfJobDal());
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()

                                           }).ToList();
            ViewBag.v = values;
            var Güncelleme = costomerManager.TGetById(id);

            return View(Güncelleme);
        }
        [HttpPost]
        public IActionResult UpdateCostomer(Costomer c)
        {
            costomerManager.TUpdate(c);
            return RedirectToAction("Index");
        }
        public IActionResult YardımMenüsü()
        {
            return View();
        }
    }
}
