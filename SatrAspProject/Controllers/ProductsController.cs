using Microsoft.AspNetCore.Mvc;
using SatrAspProject.Data;
using SatrAspProject.Models;

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
            return View(product);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Name", "Description", "Price")] ProductModel product)
        {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Details",new { id = product.Id });
            

        }


        public IActionResult Details(int? id)
        {
            var product = _db.Products.FirstOrDefault(p => p.Id==id);
            if(product==null || id==null)
            {
                return View("NotFound");
            }
            return View(product);
        }

        public IActionResult Random()
        {
            var products = _db.Products.ToList();
            var randomProduct = products[new Random().Next(products.Count)];
            return View(randomProduct);
        }

    }
}
