namespace BackendApi.Model
{
    public class Claim
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public String Status { get; set; }
        public DateTime ClaimYear { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
