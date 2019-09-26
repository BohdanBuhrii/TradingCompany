namespace DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public bool IsActive { get; set; }
    }
}
