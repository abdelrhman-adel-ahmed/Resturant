namespace Resturnat.Core.Models
{
    public class Chef
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }

    }
}
