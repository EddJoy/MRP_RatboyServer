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
    
    public partial class tipoMemoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipoMemoria()
        {
            this.memoriaRAM = new HashSet<memoriaRAM>();
            this.PlacaMadre = new HashSet<PlacaMadre>();
            this.procesador = new HashSet<procesador>();
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "ID Tipo de memoria")]
        public int idTipoMemoria { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Tipo")]
        public string tipo { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Estatus")]
        public bool estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<memoriaRAM> memoriaRAM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlacaMadre> PlacaMadre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<procesador> procesador { get; set; }
    }
}
