using Microsoft.AspNetCore.Mvc;
using WebApplication1_ASPCore_MVC.Models;

namespace WebApplication1_ASPCore_MVC.Controllers
{
    // Cuando se devuelve solo view sin indicar la vista el framework la encuentra fijandose el nombre del controlador,
    // busca la carpeta en vistas que tenga ese nombre, y luego busca el la vista que se llame igual que el metodo 
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> s_dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            return View(s_dogs);
        }

        public string HelloWorld() 
        {
            return "Hello World";
        }

        public IActionResult Create() 
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
            
        }

        public IActionResult CreateDog(DogViewModel dogViewModel) 
        {
            //return View("Index");
            s_dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
