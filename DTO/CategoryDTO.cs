namespace DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? CategoryGroupId { get; set; }

        public virtual CategoryGroupDTO CategoryGroup { get; set; }
    }
}
