﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BANKA
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BANKEntities : DbContext
    {
        public BANKEntities()
            : base("name=BANKEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SEHIR> SEHIR { get; set; }
        public virtual DbSet<TBL_BAKIYE> TBL_BAKIYE { get; set; }
        public virtual DbSet<TBL_MUSTERI> TBL_MUSTERI { get; set; }

        public static implicit operator List<object>(BANKEntities v)
        {
            throw new NotImplementedException();
        }
    }
}