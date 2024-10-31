namespace VendorBiddingAppAPI.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string? ProjectId { get; set; }
        public decimal Amount { get; set; }
        
    }
}
