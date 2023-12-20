using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Application.InterfaceUseCases;
using DesafioBaltaBlazorIBGE.Application.UseCases;
using DesafioBaltaBlazorIBGE.Blazor.Components;
using DesafioBaltaBlazorIBGE.Blazor.Components.Account;
using DesafioBaltaBlazorIBGE.Data;
using DesafioBaltaBlazorIBGE.Data.Repositories;
using DesafioBaltaBlazorIBGE.Domain.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddScoped<ICreateCityUseCase, CreateCityUseCase>();
builder.Services.AddScoped<IDeleteCityUseCase, DeleteCityUseCase>();
builder.Services.AddScoped<IUpdateCityUseCase, UpdateCityUseCase>();
builder.Services.AddScoped<IGetCitiesUseCase, GetCitiesUseCase>();
builder.Services.AddScoped<IGetCityByIdUseCase, GetCityByIdUseCase>();
builder.Services.AddScoped<IGetCityByNameUseCase, GetCityByNameUseCase>();
builder.Services.AddScoped<IGetCityByStateUseCase, GetCityByStateUseCase>();

builder.Services.AddScoped<ICreateIbgeAsyncRepository, CreateIbgeAsyncRepository>();
builder.Services.AddScoped<IDeleteRepository, DeleteRepository>();
builder.Services.AddScoped<IGetAllIbgeAsyncRepository, GetAllIbgeAsyncRepository>();
builder.Services.AddScoped<IGetByIdAsyncRepository, GetByIdAsyncRepository>();
builder.Services.AddScoped<IGetCityIbgeRepository, GetCityIbgeRepository>();
builder.Services.AddScoped<IGetStateIbgeRepository, GetStateIbgeRepository>();
builder.Services.AddScoped<IUpdateIbgeRepository, UpdateIbgeRepository>();

builder.Services.AddScoped<CreateCityUseCase>();
builder.Services.AddScoped<DeleteCityUseCase>();
builder.Services.AddScoped<UpdateCityUseCase>();
builder.Services.AddScoped<GetCitiesUseCase>();
builder.Services.AddScoped<GetCityByIdUseCase>();
builder.Services.AddScoped<GetCityByNameUseCase>();
builder.Services.AddScoped<GetCityByStateUseCase>();
builder.Services.AddScoped<EventStateService>();
builder.Services.AddScoped<RecentlyCreatedIdService>();
builder.Services.AddScoped<EventStateService>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
