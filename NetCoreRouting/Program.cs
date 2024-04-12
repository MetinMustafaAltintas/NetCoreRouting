WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//www.metinaltintas.com/Simulation/Index

// Category/GetCategories

//Test

app.MapControllerRoute(
    name: "Deneme",
    pattern: "Test/{action}/{id?}", //Eger burada action yerine de yine düz bir þey verip yer tutucu kullanmasaydýk o zaman direkt o yazýyý yine yazmak zorunda kalýrdýk
    defaults: new { Controller = "Simulation", Action = "SimulationIndex" }

    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
