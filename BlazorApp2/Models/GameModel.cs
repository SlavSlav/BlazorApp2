namespace BlazorApp2.Models
{
    public class GameModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public CompanyModel Company { get; set; }
        public List<OrderModel> GamesOrders { get; set; }


    }
}
