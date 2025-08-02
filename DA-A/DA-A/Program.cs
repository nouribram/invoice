var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline !!!!!!!!
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home");
    // The default HSTS value is 30 days. 
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=MainPage}/{id?}")
    .WithStaticAssets();


app.Run();
