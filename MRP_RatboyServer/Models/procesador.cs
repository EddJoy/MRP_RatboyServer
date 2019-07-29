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

        [System.ComponentModel.DataAnnotations.Display(Name = "ID Procesador")]
        public int idProcesador { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Nombre")]
        public string nombre { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Cantidad de nucleos")]
        public int cantidadNucleos { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Cantidad de subprocesos")]
        public int cantidadSubProcesos { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Frecuencia básica")]
        public int frecuenciaBasica { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "ID Tipo de memoria")]
        public int idTipoMemoria_FK { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "ID Socket")]
        public int idSocket_FK { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Estatus gráficos integrados")]
        public bool graficosIntegrados { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Optane")]
        public int optane { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Costo con proveedor")]
        public double costoProveedor { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Costo a venta")]
        public double costoVenta { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Marca")]
        public string marca { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Estatus")]
        public bool estatus { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Watts")]
        public double watts { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "ID Generación del procesador")]
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
