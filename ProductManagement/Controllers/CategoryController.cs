using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Infrastructure.IRepository;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory _service;

        public CategoryController(ICategory service)
        {

            _service = service;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            CategoryInfoModel model= new CategoryInfoModel();
            model.CategoriesList = _service.GetCategoryData();
            return View(model);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            CategoryInfo model = new CategoryInfo();
            model = _service.GetCategoryById(id);

            return View(model);
        }

        [HttpGet]
        public ActionResult Add(int id)
        {
            CategoryInfo model = new CategoryInfo();
            model = _service.GetCategoryById(id);
            {
                return View(model);
            }
        }


        [HttpPost]
        public ActionResult Create(CategoryInfo infomodel)
        {
            CategoryInfo model = new CategoryInfo();
            try
            {
                model = _service.AddCategory(infomodel);
                if (model.TotalRowCount > 0)
                {                    
                    return RedirectToAction(nameof(Index));
                }
                else
                {                   
                    return NotFound();
                }
            }
            catch(Exception ex)
            {               
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            CategoryInfo model = new CategoryInfo();
            model = _service.GetCategoryById(id);
            if (model != null)
            {
                return View(model);
            }
            else
            {
                return NotFound();
            }
           
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmation(int id)
        {
            CategoryInfo model = new CategoryInfo();
            try
            {
                model = _service.DeleteCategory(id);
                if (model.TotalRowCount>0)
                {
                    return RedirectToAction(nameof(Index)); 
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CategoryInfo model = new CategoryInfo();
            model = _service.GetCategoryById(id);
            if (model == null)
            {
                return View();
            }
            else
            {
                return View(model);
            }
        }


        [HttpPost]
        public ActionResult Edit(CategoryInfo infomodel)
        {
            CategoryInfo model = new CategoryInfo();
            try
            {
                model = _service.UpadateCategory(infomodel);
                if (model.TotalRowCount > 0)
                {                   
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return NotFound();
                }
               
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}