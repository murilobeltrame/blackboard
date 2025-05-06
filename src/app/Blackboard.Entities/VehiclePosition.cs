namespace Blackboard.Entities;

public record VehiclePosition(
    Guid Id,
    string LicensePlate,
    DateTime LastKnownPositionDateTime,
    string EventName,
    DateTime EventDateTime) : Event(Id, EventName, EventDateTime);
