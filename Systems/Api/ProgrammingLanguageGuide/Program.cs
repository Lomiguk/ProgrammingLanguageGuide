using ProgrammingLanguageGuide.Api;
using ProgrammingLanguageGuide.Configuration;
using ProgrammingLanguageGuide.Context;
using ProgrammingLanguageGuide.Services.Settings;
using ProgrammingLanguageGuide.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var mainSettings = Settings.Load<MainSettings>("Main");
var swaggerSettings = Settings.Load<SwaggerSettings>("Swagger");

builder.AddAppLogger();

var services = builder.Services;

services.AddHttpContextAccessor();
services.AddAppCors();

services.AddAppDbContext();

services.AddAppHealthChecks();
services.AddAppVersioning();
services.AddAppSwagger(mainSettings, swaggerSettings);

//builder.Services.AddControllers();
services.AddAppControllerAndViews();

services.RegisterAppServices();

var app = builder.Build();

app.UseAppHealthChecks();
app.UseAppSwagger();



// Configure the HTTP request pipeline.

//app.UseAuthorization();
//app.MapControllers();

app.UseAppControllerAndViews();
app.UseStaticFiles();

app.Run();
