namespace Blackboard.IntegrationEvents;

public class AssociationStatusChangedEvent
{
    public string Plate { get; set; }// String  Placa do veículo
    public Guid AssociationId { get; set; }// Guid Id da associação
    public string AssociationKey { get; set; }// String  Hash dos campos(plate, documentNumber, documentType)
    public Guid LoadId { get; set; }// Guid    Id da load
    public string LoadKey { get; set; }// String Hash dos campos(documentNumber, DocumentType, originUnityCode)
    public string DocumentNumber { get; set; }// String  Numero do documento
    public DocumentType DocumentType { get; set; }//    DocumentType Tipo do documento
    public ChannelType LoadChannel { get; set; }// ChannelType Canal de segmentação
    public DateTime DoneDate { get; set; }// DateTime    Data de finalização
    public DateTime CanceledDate { get; set; }//   DateTime Data de cancelamento
    public StatusAssociation Status { get; set; }// StatusAssociation   Status da associação
    public CloseAssociationReason CloseReason { get; set; }//  CloseAssociationReason Motivo do fechamento da associação
    public DateTime LastUpdate { get; set; }//  DateTime Data da ultima atualização da associação
}

public enum CloseAssociationReason
{
    Unknow = 0,
    Delivered = 1,
    Outlier = 2,
    TravelOverlap = 3,
    AssociationWithoutLoad = 4,
    DeliveryAppointment = 5,
    LoadOverlap = 6,
    ConciergeEvent = 7,
    VehicleDepartureFromDestination = 8
}