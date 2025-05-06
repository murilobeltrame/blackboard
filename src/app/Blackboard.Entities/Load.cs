namespace Blackboard.Entities;

public record Load(
    Guid Id,
    string Key,
    string DocumentNumber,
    string DocumentType,
    string Channel,
    string Status,
    string EventName,
    DateTime EventDateTime) : Event(Id, EventName, EventDateTime)
{
    public string? AssociatedVehicleLicensePlate { get; init; }
    public string? AssociationStatus { get; init; }
}