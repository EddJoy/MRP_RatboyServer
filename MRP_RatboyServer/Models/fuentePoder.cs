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

        [System.ComponentModel.DataAnnotations.Display(Name = "ID Fuente de poder")]
        public int idFuentePoder { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Costo con proveedor")]
        public double costoProveedor { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Costo a venta")]
        public double costoVenta { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Marca")]
        public string marca { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Modelo")]
        public string modelo { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Estatus")]
        public bool estatus { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Watts")]
        public double watts { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Tamaño")]
        public string tamaño { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Tipo de certificado")]
        public string certificado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ensamble> Ensamble { get; set; }
    }
}
