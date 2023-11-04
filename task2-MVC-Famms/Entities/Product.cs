namespace task2_MVC_Famms.Entities
{
    public class Product
    {
        public string Name { get; set; } = null!;
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; } = null!;
    }

}
