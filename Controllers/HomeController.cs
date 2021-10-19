using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC3_TEO.Models;
using PC3_TEO.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace PC3_TEO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductoContext _context;

        public HomeController(ILogger<HomeController> logger,  ProductoContext context)
        {
            _logger = logger;
            _context= context;
        }

        public IActionResult Index()
        {
            var listarProductos = _context.Productos.ToList();
            return View(listarProductos);
        }

        public IActionResult Registro()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Registrar (Producto objProducto){

           if(ModelState.IsValid){

                //Registrar
               _context.Add(objProducto);
               _context.SaveChanges();
                //Registrar
                return RedirectToAction(nameof(Index));   
             }
         
         return View ("Registro",objProducto);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
