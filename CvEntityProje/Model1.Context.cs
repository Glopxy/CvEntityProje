﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvEntityProje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CvEntityDbEntities : DbContext
    {
        public CvEntityDbEntities()
            : base("name=CvEntityDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAdres> TblAdres { get; set; }
        public virtual DbSet<TblCalismalarim> TblCalismalarim { get; set; }
        public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }
        public virtual DbSet<TblIletisim> TblIletisim { get; set; }
        public virtual DbSet<TblYetenekler> TblYetenekler { get; set; }
    }
}
