using InectionLifeTime;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IScopedOperation, Operation>();
builder.Services.AddTransient<ITransientOperation, Operation>();
builder.Services.AddSingleton<ISingletonOperation, Operation>();
builder.Services.AddTransient<OperationService, OperationService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
