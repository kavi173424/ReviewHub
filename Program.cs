using ReviewHubOrchestrationAPI.Repositories;
using ReviewHubOrchestrationAPI.Services;
using ReviewHubOrchestrationAPI.Validators;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers()
    .AddNewtonsoftJson();

builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<PublicApiService>();
builder.Services.AddScoped<ReviewValidator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
