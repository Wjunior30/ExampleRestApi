using ExampleRestApi.Application.Services.AutoMapper;
using ExampleRestApi.Application.UseCase.User.Register;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DEPENDÊNCIAS
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<AutoMapping>();
});

builder.Services.AddScoped<RegisterUserUseCase>();

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
