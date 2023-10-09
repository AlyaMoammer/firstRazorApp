using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaApp.Model;

namespace pizzaApp.Pages.forms
{
    public class customPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
           
        }

        public IActionResult OnPost ()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 3;
            if (Pizza.Peperoni) PizzaPrice += 2;
            if (Pizza.Tuna) PizzaPrice += 1;

            return RedirectToPage("/checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }

    }
}
