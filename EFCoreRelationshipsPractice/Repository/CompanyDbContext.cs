﻿using EFCoreRelationshipsPractice.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationshipsPractice.Repository
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
            : base(options)
        {
        }

        //Companies表
        public DbSet<CompanyEntity> Companies
        {
            get;
            set;
        }
        public DbSet<ProfileEntity> Profiles 
        {
            get;
            set;
        }

        public DbSet<EmployeeEntity> Employees
        {
            get;
            set;
        }
    }
}