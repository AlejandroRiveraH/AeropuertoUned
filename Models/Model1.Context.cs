﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AeropuertoUned.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AEROPUERTODBEntities : DbContext
    {
        public AEROPUERTODBEntities()
            : base("name=AEROPUERTODBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ATERRIZAJES> ATERRIZAJES { get; set; }
        public virtual DbSet<AVIONES> AVIONES { get; set; }
        public virtual DbSet<AVIONES_RETIRADOS> AVIONES_RETIRADOS { get; set; }
        public virtual DbSet<DESPEGUES> DESPEGUES { get; set; }
    }
}
