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
    
    public partial class modeloVideo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public modeloVideo()
        {
            this.Ensamble = new HashSet<Ensamble>();
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "ID Modelo Video")]
        public int idModeloVideo { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "ID Tarjeta de video")]
        public int idTarjetaVideo_FK { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Modelo")]
        public string modelo { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Estatus")]
        public bool estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ensamble> Ensamble { get; set; }
        public virtual tarjetaVideo tarjetaVideo { get; set; }
    }
}
