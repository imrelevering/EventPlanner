namespace EventPlanner.Models;

public class EventItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public string Location { get; set; } = string.Empty;

    // Optioneel: kleine summary
    public string? Description { get; set; }
}
