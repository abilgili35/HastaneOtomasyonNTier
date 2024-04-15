using DataAccess.Models.Entities;
using DataAccess.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.Property(x => x.PatientId).IsRequired();
            builder.Property(x => x.PaymentDate).IsRequired();
            builder.Property(x => x.Amount).IsRequired();

            builder.Property(x => x.Amount).HasColumnType("money");

            builder.HasData(PaymentSeed.Payments);
        }
    }
}
