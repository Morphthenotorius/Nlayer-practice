using Business.DependencyResolver;

var builder = WebApplication.CreateBuilder(args);

// 1. Controller-lər
builder.Services.AddControllers();

// 2. Swagger Servisləri
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 3. Sənin Business Layer servis qeydiyyatın
builder.Services.AddBusinessService();

var app = builder.Build();

// 4. Swagger UI Middleware (İşə salınan hissə)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();