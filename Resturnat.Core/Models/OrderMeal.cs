namespace Resturnat.Core.Models
{
    public class OrderMeal
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public int Quantity { get; set; }
    }
}
