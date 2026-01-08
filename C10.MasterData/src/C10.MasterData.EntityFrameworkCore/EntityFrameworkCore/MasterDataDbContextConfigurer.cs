using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace C10.MasterData.EntityFrameworkCore;

public static class MasterDataDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<MasterDataDbContext> builder, string connectionString)
    {
        builder.UseOracle(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<MasterDataDbContext> builder, DbConnection connection)
    {
        builder.UseOracle(connection);
    }
}
