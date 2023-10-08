namespace BlazorApp2.Models
{
    public class CompanyModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<GameModel> Games { get; set; }
    }
}
