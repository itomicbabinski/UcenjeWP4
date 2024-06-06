var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}Welcome back, we’re confirming your preferences
Let's start by signing you in and bringing over your passwords, browsing history and more from Microsoft Cloud.

Choose an account

Add new account

Sign in and sync data

Start without your data
Microsoft Privacy Statement


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
