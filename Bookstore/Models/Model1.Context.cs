﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookstore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pubsEntities : DbContext
    {
        public pubsEntities()
            : base("name=pubsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<author> authors { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<pub_info> pub_info { get; set; }
        public virtual DbSet<publisher> publishers { get; set; }
        public virtual DbSet<sale> sales { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<titleauthor> titleauthors { get; set; }
        public virtual DbSet<title> titles { get; set; }
        public virtual DbSet<discount> discounts { get; set; }
        public virtual DbSet<roysched> royscheds { get; set; }
    }
}
