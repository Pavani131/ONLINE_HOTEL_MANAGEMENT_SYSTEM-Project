﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi_HotelManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities : DbContext
    {
        public ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities()
            : base("name=ONLINE_HOTEL_MANAGEMENT_SYSTEMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<guest> guests { get; set; }
        public virtual DbSet<inventory> inventories { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
    }
}
