﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PhotosContainer : DbContext
    {
        public PhotosContainer()
            : base("name=PhotosContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Zones> Zones { get; set; }
        public virtual DbSet<Medias> Medias { get; set; }
        public virtual DbSet<PeopleGroups> PeopleGroups { get; set; }
        public virtual DbSet<Events> Events { get; set; }
    }
}
