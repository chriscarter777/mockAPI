using System.Web.Mvc;
using MockAPI.Models;

namespace MockAPI.Controllers
{
    public class AdminController : Controller
    {
        private IDataRepository repo;

        public AdminController(IDataRepository dataRepository)
        {
            this.repo = dataRepository;
        }

        public ViewResult Index()
        {
            return View(repo.RetrieveAll());
        }

        public ViewResult Edit(int id)
        {
            Place place = repo.Retrieve(id);
            return View("Edit", place);
        }

        [HttpPost]
        public ActionResult Edit(Place place)
        {
            repo.Change(place);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }

        public ViewResult Add()
        {
            Place place = new Place();
            place.Id = repo.Size();
            return View("Add", place);
        }

        [HttpPost]
        public ActionResult Add(Place place)
        {
            repo.Add(place);
            return RedirectToAction("Index");
        }
    }
}