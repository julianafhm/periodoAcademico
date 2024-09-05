using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using periodoAcademico.CQRS.Commands.Alunos.Criar;
using PeriodoAcademico.Data;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<PeriodoContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Add services to the container.
        builder.Services.AddMediatR(x => x.RegisterServicesFromAssemblies (typeof(CriarAlunoCommand).Assembly));
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("alunosApp", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            });
        });

        var app = builder.Build();

        using (var scope = app.Services.CreateScope()) {

            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<PeriodoContext>();

            var supportedCultures = new[] { new CultureInfo("pt-BR") };

            app.UseRequestLocalization(new RequestLocalizationOptions {
                DefaultRequestCulture = new RequestCulture(culture: "pt-BR", uiCulture:"pt-BR"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            


            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseCors("alunosApp");
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

        }


        app.Run();
    }
}