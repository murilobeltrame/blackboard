namespace Blackboard.Entities;

public record Anomaly(
    string AnomalyType,
    string? VehicleLicensePlate,
    string? LoadKey,
    bool Closed)
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime RecordedAt { get; init; } = DateTime.Now;
}