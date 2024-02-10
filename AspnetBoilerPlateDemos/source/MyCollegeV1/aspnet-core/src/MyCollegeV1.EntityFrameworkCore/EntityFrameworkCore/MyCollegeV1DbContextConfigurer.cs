using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCollegeV1.EntityFrameworkCore
{
    public static class MyCollegeV1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyCollegeV1DbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyCollegeV1DbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
