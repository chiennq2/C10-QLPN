using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace C10.EntityFrameworkCore;

public static class C10DbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<C10DbContext> builder, string connectionString)
    {
        builder.UseOracle(connectionString, options =>
        {
            options.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19);
        });
    }

    public static void Configure(DbContextOptionsBuilder<C10DbContext> builder, DbConnection connection)
    {
        builder.UseOracle(connection, options =>
        {
            options.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19);
        });
    }
}
