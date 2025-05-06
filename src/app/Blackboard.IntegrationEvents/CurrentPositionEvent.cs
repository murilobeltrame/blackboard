namespace Blackboard.IntegrationEvents;

public class CurrentPositionEvent
{
    public string Plate { get; set; } //String  Placa do veículo
    public DateTime Date { get; set; } //Data de envio da posição atual do veículo
    public double Latitude { get; set; } //Latitude da posição do veículo
    public double Longitude { get; set; } //Longitude da posição do veículo
    public int TechnologyType { get; set; } //Enum com as tecnologias de rastreamento
    public string TechnologyName { get; set; } //Nome da tecnologia de rastreamento do enum
}