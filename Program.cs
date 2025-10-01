var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer(); // Required for minimal APIs
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseMiddleware<NewApp.Middleware.CustomMiddleware>();
//app.UseHttpsRedirection();

app.MapControllers();
app.Run();
