﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScheduleLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchedulesEntities1 : DbContext
    {
        public SchedulesEntities1()
            : base("name=SchedulesEntities1")
        {
             this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Duration> Durations { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
