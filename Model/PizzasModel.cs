namespace pizzaApp.Model
{
    public class PizzasModel
    {
        public String ImagTitle { get; set; }
        public String PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Tuna { get; set; }
        public float FinalPrice { get; set; }

    }
}
