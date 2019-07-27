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
    
    public partial class procesador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public procesador()
        {
            this.cuelloBotella = new HashSet<cuelloBotella>();
            this.Ensamble = new HashSet<Ensamble>();
        }
    
        public int idProcesador { get; set; }
        public string nombre { get; set; }
        public int cantidadNucleos { get; set; }
        public int cantidadSubProcesos { get; set; }
        public int frecuenciaBasica { get; set; }
        public int idTipoMemoria_FK { get; set; }
        public int idSocket_FK { get; set; }
        public bool graficosIntegrados { get; set; }
        public int optane { get; set; }
        public double costoProveedor { get; set; }
        public double costoVenta { get; set; }
        public string marca { get; set; }
        public bool estatus { get; set; }
        public double watts { get; set; }
        public int idGeneracionProcesador_FK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuelloBotella> cuelloBotella { get; set; }
        public virtual detalleGeneracionProcesador detalleGeneracionProcesador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ensamble> Ensamble { get; set; }
        public virtual socket socket { get; set; }
        public virtual tipoMemoria tipoMemoria { get; set; }
    }
}
