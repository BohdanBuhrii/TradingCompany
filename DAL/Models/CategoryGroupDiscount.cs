namespace DAL.Models
{
    public class CategoryGroupDiscount
    {
        public int DiscountId { get; set; }
        public int CategoryGroupId { get; set; }

        public virtual CategoryGroup CategoryGroup { get; set; }
        public virtual Discount Discount { get; set; }
    }
}
