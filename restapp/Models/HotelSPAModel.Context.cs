﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelEntities : DbContext
    {
        public HotelEntities()
            : base("name=HotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Treatments> Treatments { get; set; }
        public DbSet<TreatmentsHistory> TreatmentsHistory { get; set; }
    }
}
