using FluentValidation;
using FluentValidationSample.Models.DTO;

namespace FluentValidationSample.Models.Validations;

public class AddUniversityRequestDtoValidator : AbstractValidator<AddUniversityRequestDto>
{
    public AddUniversityRequestDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.City).NotEmpty().WithMessage("City is required");
    }
}
