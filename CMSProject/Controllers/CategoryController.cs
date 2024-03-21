using CMSProject.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CMSProject.Data.Repository;

namespace CMSProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IDataHelper<Category> _dataHelper;

        public CategoryController(IDataHelper<Category> dataHelper)
        {
            _dataHelper = dataHelper;   
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            return View(_dataHelper.GetAllData());
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category collection)
        {
            try
            {
                _dataHelper.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category collection)
        {
            try
            {
                _dataHelper.Edit(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                _dataHelper.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
