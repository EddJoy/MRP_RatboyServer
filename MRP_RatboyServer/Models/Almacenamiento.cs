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
    
    public partial class Almacenamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Almacenamiento()
        {
            this.Almacenamiento_Ensamble = new HashSet<Almacenamiento_Ensamble>();
        }
    
        public int idAlmacenamiento { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string capacidad { get; set; }
        public double costoProveedor { get; set; }
        public double costoVenta { get; set; }
        public bool estatus { get; set; }
        public string marca { get; set; }
        public Nullable<double> rpm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacenamiento_Ensamble> Almacenamiento_Ensamble { get; set; }
    }
}
