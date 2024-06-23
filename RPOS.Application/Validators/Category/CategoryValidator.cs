using FluentValidation;
using RPOS.Application.Dtos.Request;

namespace RPOS.Application.Validators.Category
{
    public class CategoryValidator : AbstractValidator<CategoryRequestDto>
    {
        public CategoryValidator() 
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("El campo no pueder ser nulo")
                .NotEmpty().WithMessage("El campo no puede ser vacio");
        }
    }
}
