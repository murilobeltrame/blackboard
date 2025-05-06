namespace Blackboard.IntegrationEvents;

public class VehicleCreatedEvent
{
    public string LicensePlate { get; set; }
    public int VehiclePart { get; set; }
    public Guid CarrierId { get; set; }
    public string CarrierCode { get; set; }
    public DateTime CreatedDate { get; set; }
    public int PalletCapacity { get; set; }
    public bool Monitored { get; set; }
    public bool GenerateTR { get; set; }
    public bool GenerateTPFR { get; set; }
    public bool GenerateStopArea { get; set; }
    public DateTime DateMonitored { get; set; }
    public Guid OwnerBusinessUnitId { get; set; }
    public string OnwerBusinessUnitCode { get; set; }
    public int TractorTractions { get; set; }
}