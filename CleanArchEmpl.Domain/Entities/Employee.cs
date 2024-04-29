using CleanArchEmpl.Domain.Common;

namespace CleanArchEmpl.Domain.Entities
{
    public class Employee : BaseAuditableEntity
    { 
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
