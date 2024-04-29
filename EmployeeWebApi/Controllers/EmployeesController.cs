using CleanArchEmpl.Application.Extensions.Employees.Queries.GetAllEmployees;
using CleanArchEmpl.Application.Extensions.Employees.Queries.GetEmployeeById;
using CleanArchEmpl.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<Result<List<GetAllEmployeesDto>>>> Get()
        {
            return await _mediator.Send(new GetAllEmployeesQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Result<GetEmployeeByIdDto>>> GetPlayersById(int id)
        {
            return await _mediator.Send(new GetEmployeeByIdQuery(id));
        }
      
    }
}


