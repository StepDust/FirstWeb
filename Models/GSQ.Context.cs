﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GSQ_PaChongEntities : DbContext
    {
        public GSQ_PaChongEntities()
            : base("name=GSQ_PaChongEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GSQ_DataItem> GSQ_DataItem { get; set; }
        public virtual DbSet<GSQ_DataItemDetail> GSQ_DataItemDetail { get; set; }
        public virtual DbSet<GSQ_Log> GSQ_Log { get; set; }
        public virtual DbSet<GSQ_Manager> GSQ_Manager { get; set; }
        public virtual DbSet<GSQ_Manager_Role> GSQ_Manager_Role { get; set; }
        public virtual DbSet<GSQ_Manager_Role_Value> GSQ_Manager_Role_Value { get; set; }
        public virtual DbSet<GSQ_Navigation> GSQ_Navigation { get; set; }
        public virtual DbSet<GSQ_News> GSQ_News { get; set; }
        public virtual DbSet<GSQ_NewsClass> GSQ_NewsClass { get; set; }
        public virtual DbSet<GSQ_NewsWords> GSQ_NewsWords { get; set; }
        public virtual DbSet<GSQ_Users> GSQ_Users { get; set; }
        public virtual DbSet<GSQ_UsersInterest> GSQ_UsersInterest { get; set; }
        public virtual DbSet<GSQ_UsersNews> GSQ_UsersNews { get; set; }
        public virtual DbSet<GSQ_Web> GSQ_Web { get; set; }
        public virtual DbSet<GSQ_Words> GSQ_Words { get; set; }
    }
}
