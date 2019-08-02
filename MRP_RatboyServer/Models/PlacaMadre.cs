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
    
    public partial class PlacaMadre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlacaMadre()
        {
            this.GeneracionSoportadaPlacaMadre = new HashSet<GeneracionSoportadaPlacaMadre>();
        }
    
        public int idPlacaMadre { get; set; }
        public string Nombre { get; set; }
        public int idtipoMemoria { get; set; }
        public int maxVelocidadMemoria { get; set; }
        public Nullable<bool> statusM2 { get; set; }
        public int cantidadM2 { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Gaming { get; set; }
        public int idTamaño_FK { get; set; }
        public byte[] codBarras { get; set; }
        public int PCIexpress { get; set; }
        public int SATA { get; set; }
        public bool estatus { get; set; }
        public double costoProveedor { get; set; }
        public double costoVenta { get; set; }
        public Nullable<int> marca { get; set; }
        public string modelo { get; set; }
        public Nullable<double> watts { get; set; }
        public int idSocket_FK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GeneracionSoportadaPlacaMadre> GeneracionSoportadaPlacaMadre { get; set; }
        public virtual Marca Marca1 { get; set; }
        public virtual socket socket { get; set; }
        public virtual Tamaño Tamaño { get; set; }
        public virtual tipoMemoria tipoMemoria { get; set; }
    }
}
