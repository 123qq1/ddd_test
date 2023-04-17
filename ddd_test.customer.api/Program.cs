using ddd_test.customer.infrastructure;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEventStoreClient(
    new Uri(
        builder.Configuration.GetSection("EventStore").Get<string>()
        )

    );

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddTransient<customerRepository>();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "MVCCallWebAPI");
    options.RoutePrefix = string.Empty;
});

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();
