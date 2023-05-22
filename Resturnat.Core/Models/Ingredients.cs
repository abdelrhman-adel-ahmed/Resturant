namespace Resturnat.Core.Models
{
    public class Ingredients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Meal> Meals { get; set; }
    }
}
