//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MRP_RatboyServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class fuentePoder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fuentePoder()
        {
            this.Ensamble = new HashSet<Ensamble>();
        }
    
        public int idFuentePoder { get; set; }
        public double costoProveedor { get; set; }
        public double costoVenta { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public bool estatus { get; set; }
        public double watts { get; set; }
        public string tamaño { get; set; }
        public string certificado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ensamble> Ensamble { get; set; }
    }
}
