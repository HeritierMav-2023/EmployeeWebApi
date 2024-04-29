using CleanArchEmpl.Application.Interfaces;


namespace CleanArchEmpl.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
