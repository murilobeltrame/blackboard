using System.ComponentModel;

namespace Blackboard.IntegrationEvents;

public class VehicleEvent
{
    public string Plate { get; set; }
    public string CarrierSapCode { get; set; }
    public DateTime LastUpdate { get; set; }
    public int TruckPalletCapacity { get; set; } //Quantidade de palletes que o veículo consegue transportar
    public bool ScaledBusinessUnity { get; set; } // Unidade de Negócio dimensionada
    public bool Scaled { get; set; } // Está Dimensionado
    public ChannelType Channel { get; set; } // Nullable Canal de segmentação
    public bool Monitored { get; set; } // Veiculo Monitorado
    public bool GenerateTR { get; set; } // Veiculo Gera TR
    public bool GenerateTPFR { get; set; } // Veiculo Gera TPFR
    public bool GenerateStopArea { get; set; } // Veiculo Gera Parada em Area Conhecida
    public bool MonitoredNASA { get; set; } // Veiculo Monitorado Nasa
    public bool MonitoredTAOBAO { get; set; } // Veiculo Monitorado TAOBAO
    public bool MonitoredConnext { get; set; } // Veiculo Monitorado Connext
    public bool Unavailibility { get; set; } // Veiculo Possui indisponibilidade
    public DateTime DateMonitored { get; set; } // Data de incio do Monitoramento
    public string BusinessUnitySapCode { get; set; } // Unidade de Negócio quando Veiculo de Revenda ou Fornecedor
    public VehicleTractions VehicleTractions { get; set; } // Flag Tipo de tração do Veiculo 0 = None(Não possui) / 1 = Padrão / 2 = Double-Deck / 4 = Bitrem
    public bool IsDeleted { get; set; } // Veiculo Foi Deletado
    public IEnumerable<Guid> Segmentations { get; set; } // Lista de ids que o usuário precisa ter pra poder visualizar a informação
}

public enum ChannelType
{
    [Description("INSUMOS - GERAL")]
    InsumosGeral = 10,
    [Description("REVENDA")]
    Revenda = 40,
    [Description("INSUMOS - LÍQUIDO")]
    InsumosLiquido = 50,
    [Description("INSUMOS - LATA")]
    InsumosLata = 60,
    [Description("INSUMOS - MALTE")]
    InsumosMalte = 70,
    [Description("INSUMOS - GARRAFA")]
    InsumosGarrafa = 80,
    [Description("INSUMOS - AÇÚCAR")]
    InsumosAcucar = 90,
}

public enum VehicleTractions
{
    [Description("")]
    None = 0,
    [Description("Padrão")]
    Default = 10,
    [Description("Double-Deck")]
    DoubleDeck = 20,
    [Description("Bitrem")]
    DoubleTrailer = 40
}