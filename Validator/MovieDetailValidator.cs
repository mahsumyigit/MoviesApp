using FluentValidation;

public class MovieDetailValidator : AbstractValidator<MovieDetail>
{
    public MovieDetailValidator()
    {
        RuleFor(x => x.Detail).EmailAddress(FluentValidation.Validators.EmailValidationMode.Net4xRegex).WithMessage("Detail formati hatalıdır");
        RuleFor(x => x.Director).NotNull().WithMessage("Director kurallara düzgün bir şekilde oluşturulmalıdır.");
        RuleFor(x => x.Language).NotNull().WithMessage("Language kurallara düzgün bir şekilde oluşturulmalıdır.");
        RuleFor(x => x.Ratings).NotNull().WithMessage("Ratings kurallara düzgün bir şekilde oluşturulmalıdır.");
        RuleFor(x => x.MovieYear).NotNull().WithMessage("MovieYear kurallara düzgün bir şekilde oluşturulmalıdır.");
        RuleFor(x => x.Type).NotNull().WithMessage("Type kurallara düzgün bir şekilde oluşturulmalıdır.");

    }
}
