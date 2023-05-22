namespace Resturnat.Core.Models
{
    public class Meal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; }
        public virtual ICollection<Ingredients> Ingredients { get; set; }
    }
}
