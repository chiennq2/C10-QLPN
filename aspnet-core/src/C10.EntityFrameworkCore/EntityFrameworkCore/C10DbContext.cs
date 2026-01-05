using Abp.Zero.EntityFrameworkCore;
using C10.Authorization.Roles;
using C10.Authorization.Users;
using C10.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace C10.EntityFrameworkCore;

public class C10DbContext : AbpZeroDbContext<Tenant, Role, User, C10DbContext>
{
    /* Define a DbSet for each entity of the application */

    public C10DbContext(DbContextOptions<C10DbContext> options)
        : base(options)
    {
    }
}
