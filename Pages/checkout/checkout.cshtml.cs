using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaApp.Data;
using pizzaApp.Model;

namespace pizzaApp.Pages.checkout
{
    [BindProperties(SupportsGet =true)]
    public class checkoutModel : PageModel
    {
        public String PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public String ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public checkoutModel(ApplicationDbContext context)
        {
            _context= context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName)) {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "pizza3";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.MyProperty.Add(pizzaOrder);
            _context.SaveChanges();

        }

    }
}
