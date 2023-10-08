namespace BlazorApp2.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public UserModel User { get; set; }
        public GameModel Game { get; set; }
    }
}
