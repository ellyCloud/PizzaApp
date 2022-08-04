namespace Pizzaland.Models
{
    public class PizzaOrder
    {
        // identify primary key 
        public int Id { get; set; }
        public string? PizzaName { get; set; }

       
        public float BasePrice { get; set; }
    }
}
