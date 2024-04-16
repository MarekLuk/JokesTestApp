using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JokesWebApp.Controllers
{
    public class JosephsController1 : Controller
    {
        // GET: JosephsController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: JosephsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JosephsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JosephsController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JosephsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JosephsController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JosephsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JosephsController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
