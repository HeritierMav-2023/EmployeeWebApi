using CleanArchEmpl.Application.Common.Mappings;
using CleanArchEmpl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchEmpl.Application.Extensions.Employees.Queries.GetAllEmployees
{
    public class GetAllEmployeesDto : IMapFrom<Employee>
    {
        public int Id { get; init; }
        public string? FirstName { get; init; }

        public string? LastName { get; init; }

        public string? Email { get; init; }

        public string? PhoneNumber { get; init; }
    }

}
