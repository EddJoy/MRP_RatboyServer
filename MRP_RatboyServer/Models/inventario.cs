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
    
    public partial class inventario
    {
        public int id { get; set; }
        public int idComponente { get; set; }
        public string codigoBarra { get; set; }
        public int tipoProducto { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public decimal precio { get; set; }
        public int idProveedor { get; set; }
        public int cantidad { get; set; }
    }
}
