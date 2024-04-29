using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchEmpl.Application.Interfaces;
using CleanArchEmpl.Domain.Entities;
using CleanArchEmpl.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchEmpl.Application.Extensions.Employees.Queries.GetAllEmployees
{
    public record GetAllEmployeesQuery : IRequest<Result<List<GetAllEmployeesDto>>>;

    internal class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, Result<List<GetAllEmployeesDto>>>
    {
        #region Object Reference
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GetAllEmployeesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Implementation Methods
        public async Task<Result<List<GetAllEmployeesDto>>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var students = await _unitOfWork.Repository<Employee>().Entities
                       .ProjectTo<GetAllEmployeesDto>(_mapper.ConfigurationProvider)
                       .ToListAsync(cancellationToken);

            return await Result<List<GetAllEmployeesDto>>.SuccessAsync(students);
        }
        #endregion

    }

}
