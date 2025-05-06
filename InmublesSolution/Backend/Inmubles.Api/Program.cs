using Inmubles.Aplication.Mappings;
using Inmubles.Aplication.Queries.Owner;
using Inmubles.Domain.Interfaces;
using Inmubles.Infrastructure;
using Inmubles.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configuración de MongoDB
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

// Registra los servicios
builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();
builder.Services.AddScoped<IPropertyRepository, PropertyRepository>();



builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllOwnersQuery).Assembly));
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3000") // Cambia esto si tu frontend usa otro puerto
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
