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
    
    public partial class DBS
    {
        public int ID { get; set; }
        public Nullable<int> IdPedido { get; set; }
        public Nullable<decimal> MontoTotal { get; set; }
        public Nullable<int> IdModoDePago { get; set; }
    
        public virtual ModoDePago ModoDePago { get; set; }
        public virtual PS PS { get; set; }
    }
}
