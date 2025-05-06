namespace Blackboard.Entities;

public abstract record Event(
    Guid Id,
    string EventName,
    DateTime DateTime)
{
    public DateTime RecordedAt { get; init; } = DateTime.Now;
}