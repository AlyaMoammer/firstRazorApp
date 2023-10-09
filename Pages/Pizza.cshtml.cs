using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaApp.Model;

namespace pizzaApp.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel() 
            { ImagTitle="pizza1" , PizzaName="Magerita" , BasePrice=2,TomatoSauce=true,Cheese=true ,FinalPrice=4 },
             new PizzasModel()
            { ImagTitle="pizza3" , PizzaName="Pepperoni" , BasePrice=2,TomatoSauce=true,Peperoni=true ,FinalPrice=5 },
             new PizzasModel()
            { ImagTitle="pizza1" , PizzaName="Mushroom" , BasePrice=2,TomatoSauce=true,Cheese=true ,FinalPrice=4 },
             new PizzasModel()
            { ImagTitle="pizza2" , PizzaName="Hawaiian" , BasePrice=2,TomatoSauce=true,Peperoni=true ,FinalPrice=5 }
        };
        public void OnGet()
        {
        }
    }
}
