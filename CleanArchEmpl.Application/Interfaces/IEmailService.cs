using CleanArchEmpl.Application.DTOs;

namespace CleanArchEmpl.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequestDto request);
    }
}
