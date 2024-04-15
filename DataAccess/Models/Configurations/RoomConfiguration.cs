using DataAccess.Models.Entities;
using DataAccess.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(x => x.RoomNumber).IsRequired();
            builder.Property(x => x.FloorNumber).IsRequired();
            builder.Property(x => x.BuildingNumber).IsRequired();

            builder.HasOne(x => x.Doctor).WithOne(x => x.Room).HasForeignKey<Room>(x => x.ID);

            builder.HasData(RoomSeed.Rooms);
        }
    }
}
