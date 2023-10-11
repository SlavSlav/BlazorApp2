namespace BlazorApp2.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserModel User { get; set; }
        public Guid GameId { get; set; }
        public GameModel Game { get; set; }
    }
}
