using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzaDbContext db = new PizzaDbContext();

            List<Pizza> listOfPizzas = db.Pizzas.ToList();

            return View(listOfPizzas);
        }
        public IActionResult Detail(int id)
        {

            PizzaDbContext db = new PizzaDbContext();

            Pizza pizza = db.Pizzas.Where(p => p.Id == id).FirstOrDefault();

            return View(pizza);
        }
    }


}
