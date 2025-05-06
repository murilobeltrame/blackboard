using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Blackboard.IntegrationEvents;

public class LoadCreatedEvent
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
    public string DocumentNumber { get; set; }
    public DocumentType DocumentType { get; set; }
    public LoadSource LoadSource { get; set; }
    public LoadStatus Status { get; set; }
    public bool IsDropAndHook { get; set; }
    public DateTime? DropAndHookDate { get; set; }

    public class LoadItem
    {
        public string OrderNumber { get; set; }
        public string SkuCode { get; set; }
        public decimal Quantity { get; set; }
        public string SkuDescription { get; set; }
    }
}

public enum DocumentType
{
    [Description("Dt")]
    Dt = 0,
    [Description("Order")]
    Order = 10,
    [Description("FreightOrder")]
    FreightOrder = 60,
    [Description("InvalidDocument")]
    InvalidDocument = 99
}

public enum LoadSource
{
    Unknown = 0,
    ERP = 10,
    Api = 20
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LoadStatus
{
    [Description("Planejada")]
    Planned = 0,
    [Description("Carregando")]
    Loading = 10,
    [Description("Carregada")]
    Loaded = 20,
    [Description("Em trânsito")]
    Transit = 30,
    [Description("Descarregando")]
    Unloading = 40,
    [Description("Entregue")]
    Delivered = 50,
    [Description("Cancelada")]
    Canceled = 60,
    [Description("Estacionado para carregamento")]
    ParkArrival = 70
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Channel
{
    Unknow = 0,
    CEDCMP = 10,
    ASVD = 20,
    SupplyOwned = 30,
    SupplyPartner = 40,
    Resale = 50
}