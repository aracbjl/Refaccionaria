//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Pedido = new HashSet<Pedido>();
        }
    
        public string ID { get; set; }
        public string Contraseña { get; set; }
        public int IdTipoEmpleado { get; set; }
        public string Nombre { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public decimal Sueldo { get; set; }
    
        public virtual TipoEmpleado TipoEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
