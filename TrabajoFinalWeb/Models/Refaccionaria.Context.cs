﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoFinalWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Baterias_dbEntities : DbContext
    {
        public Baterias_dbEntities()
            : base("name=Baterias_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DBS> DBS { get; set; }
        public virtual DbSet<DetalleBoleta> DetalleBoleta { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<ModoDePago> ModoDePago { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PPS> PPS { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Productos_Pedidos> Productos_Pedidos { get; set; }
        public virtual DbSet<PS> PS { get; set; }
        public virtual DbSet<TipoEmpleado> TipoEmpleado { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
    }
}
