using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EFDeployTest1.Configuration;

namespace EFDeployTest1.Migrations.ConfigurationDb
{
    [DbContext(typeof(ConfigurationDbContext))]
    partial class ConfigurationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFDeployTest1.Configuration.ConfigValue", b =>
                {
                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("Key");
                });
        }
    }
}
