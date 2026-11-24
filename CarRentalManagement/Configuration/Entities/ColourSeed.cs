using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configuration.Entities
{
    public class ColourSeed : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    Id = 1,
                    Name = "Black",
                    DataCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DataUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Colour
                {
                    Id = 2,
                    Name = "Blue",
                    DataCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DataUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
             );
        }
    }
}
