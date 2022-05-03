using Duende.IdentityServer.EntityFramework.Options;
using HRAppMudBlazorProject.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HRAppMudBlazorProject.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<HRAppMudBlazorProject.Shared.Department> Department { get; set; }
        public DbSet<HRAppMudBlazorProject.Shared.Designation> Designation { get; set; }
        public DbSet<HRAppMudBlazorProject.Shared.Employee> Employee { get; set; }
    }
}