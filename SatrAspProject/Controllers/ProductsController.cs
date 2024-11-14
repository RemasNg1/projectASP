using Microsoft.AspNetCore.Mvc;
using SatrAspProject.Data;

namespace SatrAspProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;

        public ProductsController(AppDbContext db)
        {
            _db=db;
        }
        public IActionResult Index()
        {
            var product = _db.Products.ToList();
            ViewData["product"]=product;
            return View();
        }

        public IActionResult Details(int? id)
        {
            var product = _db.Products.ToList().Find(p => p.Id==id);
            if(product==null || id==null)
            {
                return View("NotFound");
            }
            ViewData["product"]=product;
            return View();
        }

        public IActionResult Random()
        {
            var products = _db.Products.ToList();
            var randomProduct = products[new Random().Next(products.Count)];
            ViewData["random"]=randomProduct;
            return View();
        }

    }
}
