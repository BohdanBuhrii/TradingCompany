namespace DAL.Models
{
    public class CustomerUser
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
    }
}
