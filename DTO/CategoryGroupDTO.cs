using System.Collections.Generic;

namespace DTO
{
    public class CategoryGroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CategoryDTO> Categories { get; set; }
    }
}
