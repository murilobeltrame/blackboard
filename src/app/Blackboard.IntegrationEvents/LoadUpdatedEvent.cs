namespace Blackboard.IntegrationEvents;

public class LoadUpdatedEvent
{
    public string Key { get; set; }
    public Guid LoadId { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public int PalletNumber { get; set; }
    public DateTime? PlannedDate { get; set; }
    public DateTime LastUpdate { get; set; }
    public Channel Channel { get; set; }
    public List<LoadItem>? Content { get; set; }

    public class LoadItem
    {
        public string OrderNumber { get; set; }
        public string SkuCode { get; set; }
        public decimal Quantity { get; set; }
        public string SkuDescription { get; set; }
    }
}
