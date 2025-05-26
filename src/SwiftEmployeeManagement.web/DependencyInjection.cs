using SwiftEmployeeManagement.Application.Abstractions.Repositories;
using SwiftEmployeeManagement.Infrastructure.Repositories;

namespace SwiftEmployeeManagement.web;

public static class DependencyInjection
{
    public static IServiceCollection AddWebServices(this IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddRazorPages();
        services.AddHttpContextAccessor();


        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        return services;
    }
}
