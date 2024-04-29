using AutoMapper;
using CleanArchEmpl.Application.Interfaces;
using CleanArchEmpl.Domain.Entities;
using CleanArchEmpl.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchEmpl.Application.Extensions.Employees.Queries.GetEmployeeById
{
    public record GetEmployeeByIdQuery : IRequest<Result<GetEmployeeByIdDto>>
    {
        public int Id { get; set; }

        public GetEmployeeByIdQuery()
        {

        }

        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }
    }

    internal class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, Result<GetEmployeeByIdDto>>
    {
        #region Propriétes

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructeur
        public GetEmployeeByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Ovverides Methods
        public async Task<Result<GetEmployeeByIdDto>> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Repository<Employee>().GetByIdAsync(request.Id);

            var emp = _mapper.Map<GetEmployeeByIdDto>(entity);

            return await Result<GetEmployeeByIdDto>.SuccessAsync(emp);

        }
        #endregion
    }
}
