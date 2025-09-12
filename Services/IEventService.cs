using EventPlanner.Models;

namespace EventPlanner.Services
{
    public interface IEventService
    {
        Task<IReadOnlyList<EventItem>> GetEventsAsync();
        Task<EventItem?> GetEventAsync(Guid id);
    }
}
