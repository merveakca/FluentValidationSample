
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidationSample.Models.DTO;
using FluentValidationSample.Models.Validations;

namespace FluentValidationSample;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddFluentValidationAutoValidation()
            .AddFluentValidationClientsideAdapters();

        builder.Services.AddScoped<IValidator<CreateStudentRequestDto>, CreateStudentRequestDtoValidator>();
        builder.Services.AddScoped<IValidator<UpdateStudentRequestDto>, UpdateStudentRequestDtoValidator>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
