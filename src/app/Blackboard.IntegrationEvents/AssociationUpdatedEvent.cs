namespace Blackboard.IntegrationEvents;

public class AssociationUpdatedEvent
{
    public string Plate { get; set; }//String  Placa do veículo
    public Guid AssociationId { get; set; }//Guid Id da associação
    public string AssociationKey { get; set; }//String  Hash dos campos(plate, documentNumber, documentType)
    public Guid LoadId { get; set; }//Guid    Id da load
    public string LoadKey { get; set; }//String Hash dos campos(documentNumber, DocumentType, originUnityCode)
    public string DocumentNumber { get; set; }//String  Numero do documento
    public DocumentType DocumentType { get; set; }// DocumentType Tipo do documento
    public ChannelType Channel { get; set; }// ChannelType Canal de segmentação
    public DateTime StartDate { get; set; }//DateTime    Data de inicio da associação
    public DateTime LastUpdate { get; set; }//DateTime Data da última vez que a associação foi atualizada
    public string Origin { get; set; }//String  Origem da associação
    public string Destination { get; set; }// String Destino da associação
    public CheckinSource CheckinSource { get; set; }// CheckinSource   Fonte do Checkin que criou associação
    public StatusAssociation Status { get; set; }//StatusAssociation   Status da Associação
    public Guid CheckinId { get; set; }//   Guid Id do checkin mais priorizado da associação
}