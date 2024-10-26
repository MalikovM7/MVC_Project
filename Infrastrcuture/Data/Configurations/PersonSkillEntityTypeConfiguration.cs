using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Contexts.Configurations
{
    public class PersonSkillEntityTypeConfiguration : IEntityTypeConfiguration<PersonSkill>
    {
        public void Configure(EntityTypeBuilder<PersonSkill> builder)
        {
            builder.Property(m => m.PersonId).HasColumnType("int");
            builder.Property(m => m.SkillId).HasColumnType("int");
            builder.Property(m => m.Mode).HasColumnType("int").IsRequired();
            builder.Property(m => m.Percentage).HasColumnType("tinyint");
            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(m => m.LastModifiedAt).HasColumnType("datetime");
            builder.Property(m => m.LastModifiedBy).HasColumnType("int").IsRequired(false);
            builder.Property(m => m.DeletedAt).HasColumnType("datetime");
            builder.Property(m => m.DeletedBy).HasColumnType("int").IsRequired(false);

            builder.HasKey(m => m.PersonId);
            builder.ToTable("PersonSkills");
        }
    }
}
