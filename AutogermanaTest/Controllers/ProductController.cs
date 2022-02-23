using AutogermanaTest.Core.Entities;
using AutogermanaTest.Core.Interfaces.UsesCases;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AutogermanaTest.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductInteractor _productInteractor;
        public ProductController(IProductInteractor productInteractor)
        {
            _productInteractor = productInteractor ?? throw new ArgumentNullException(nameof(productInteractor));
        }

        public IActionResult Index()
        {
            try
            {
                var products = _productInteractor.GetProducts();
                return View(products);
            } 
            catch (Exception exception)
            {
                ModelState.AddModelError("", "Ocurrio un error por favor contacte al administrador del sistema");
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var product = _productInteractor.GetProductById(id);
                return View(product);
            }
            catch (Exception exception)
            {
                ModelState.AddModelError("", "Ocurrio un error por favor contacte al administrador del sistema");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product) =>
            ExecuteFunc(() => _productInteractor.InsertProduct(product));

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult Edit_Post(Product product) =>
            ExecuteFunc(() => _productInteractor.UpdateProduct(product));

        public IActionResult Delete(int id) =>
            ExecuteFunc(() => _productInteractor.DeleteProduct(id));


        [HttpGet("categories")]
        public IActionResult Categories()
        {
            var response = _productInteractor.GetCategories();
            return Json(response);
        }

        private IActionResult ExecuteFunc(Func<bool> func)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(func())
                        return RedirectToAction("Index");
                    throw new Exception();
                }
            }
            catch (Exception exception)
            {
                ModelState.AddModelError("", "Ocurrio un error al crear el producto, por favor intente de nuevo.");
            }

            return View();
        }
    }
}
