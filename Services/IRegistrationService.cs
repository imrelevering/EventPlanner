using EventPlanner.Models;

namespace EventPlanner.Services
{
    public interface IRegistrationService
    {
        Task RegisterAsync(Registration registration);
        Task<IReadOnlyList<Registration>> GetRegistrationsForEventAsync(Guid eventId);
    }
}
