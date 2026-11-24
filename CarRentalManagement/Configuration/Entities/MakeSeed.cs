using CarRentalManagement.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configuration.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    Name = "BMW",
                    DataCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DataUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Make
                {
                    Id = 2,
                    Name = "Toyota",
                    DataCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DataUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
