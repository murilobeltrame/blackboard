namespace Blackboard.Entities;

public record Vehicle(
    Guid Id,
    string LicensePlate,
    bool Monitored,
    string EventName,
    DateTime EventDateTime) : Event(Id, EventName, EventDateTime)
{
    public bool Deleted { get; init; } = false;
    public bool? Scaled { get; init; }
}