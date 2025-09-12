using EventPlanner.Models;

namespace EventPlanner.Services;

public class InMemoryEventService : IEventService
{
    private readonly List<EventItem> _events = new()
    {
        new EventItem { Name = "Tech Meetup Almere", Date = DateOnly.FromDateTime(DateTime.Today.AddDays(7)), Location = "Almere Stad", Description = "Community talks & networking" },
        new EventItem { Name = "C# Workshop", Date = new DateOnly(DateTime.Today.Year, 11, 5), Location = "Amsterdam", Description = "Hands-on Blazor" },
        new EventItem { Name = "Product Launch", Date = new DateOnly(DateTime.Today.Year, 12, 1), Location = "Utrecht", Description = "Keynote & demo" },
    };

    public Task<IReadOnlyList<EventItem>> GetEventsAsync()
        => Task.FromResult<IReadOnlyList<EventItem>>(_events.OrderBy(e => e.Date).ToList());

    public Task<EventItem?> GetEventAsync(Guid id)
        => Task.FromResult(_events.FirstOrDefault(e => e.Id == id));
}