﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FiveTeam.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLySanPhamEntities2 : DbContext
    {
        public QuanLySanPhamEntities2()
            : base("name=QuanLySanPhamEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ProductFiveTeam> ProductFiveTeams { get; set; }
        public virtual DbSet<BlogsFiveTeam> BlogsFiveTeams { get; set; }
        public virtual DbSet<CategoriesFiveTeam> CategoriesFiveTeams { get; set; }
        public virtual DbSet<ReviewFiveTeam> ReviewFiveTeams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public object Produtts { get; internal set; }
    }
}
