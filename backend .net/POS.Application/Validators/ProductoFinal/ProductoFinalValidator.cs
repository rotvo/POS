using FluentValidation;
using POS.Application.Dtos.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Application.Validators.ProductoFinal
{
    public class ProductoFinalValidator: AbstractValidator<ProductoFinalRequestDto>
    {
        public ProductoFinalValidator()
        {
            RuleFor(x => x.NombreProducto)
                .NotNull().WithMessage("El campo NombreProducto no puede ser nulo.")
                .NotEmpty().WithMessage("El campo NombreProducto no puede ser vacio");
        }
    }
}
