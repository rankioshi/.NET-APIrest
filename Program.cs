using Person.Routes;
using Person.Data;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços padrão para Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PersonContext>();

var app = builder.Build();

// Ativa Swagger em ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.PersonRoutes();
app.Run();