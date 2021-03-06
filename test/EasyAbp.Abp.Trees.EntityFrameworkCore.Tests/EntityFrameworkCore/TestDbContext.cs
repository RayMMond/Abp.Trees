﻿using EasyAbp.Abp.Trees.App;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EasyAbp.Abp.Trees.EntityFrameworkCore
{
    public class TestDbContext : AbpDbContext<TestDbContext>
    {
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public TestDbContext(DbContextOptions<TestDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<OrganizationUnit>(b =>
            {
                b.TryConfigureExtraProperties();
                b.TryConfigureConcurrencyStamp();
            });
        }
    }
}