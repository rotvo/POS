using AutoMapper;
using POS.Application.Validators.ProductoFinal;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Application.Services
{
    public class ProductosFinalApplication
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly ProductoFinalValidator _validationRules;
    }
}
