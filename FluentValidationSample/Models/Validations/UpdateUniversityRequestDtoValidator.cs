using FluentValidation;
using FluentValidationSample.Models.DTO;

namespace FluentValidationSample.Models.Validations;

public class UpdateUniversityRequestDtoValidator : AbstractValidator<UpdateUniversityRequestDto>
{
    public UpdateUniversityRequestDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is not empty");
        RuleFor(x => x.City).NotEmpty().WithMessage("City is not empty");
    }
}
