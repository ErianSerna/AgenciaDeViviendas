//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgenciaViviendasParcial.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int Id_Venta { get; set; }
        public Nullable<int> Id_Vivienda_FK { get; set; }
        public Nullable<int> Id_Cliente_FK { get; set; }
        public Nullable<decimal> ValorVenta { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Vivienda Vivienda { get; set; }
    }
}
