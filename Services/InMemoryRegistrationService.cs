using EventPlanner.Models;

namespace EventPlanner.Services
{
    public class InMemoryRegistrationService : IRegistrationService
    {
        private readonly List<Registration> _registrations = new();

        public Task RegisterAsync(Registration registration)
        {
            _registrations.Add(registration);
            return Task.CompletedTask;
        }

        public Task<IReadOnlyList<Registration>> GetRegistrationsForEventAsync(Guid eventId)
        {
            var list = _registrations
                .Where(r => r.EventId == eventId)
                .ToList();

            return Task.FromResult<IReadOnlyList<Registration>>(list);
        }
    }
}
