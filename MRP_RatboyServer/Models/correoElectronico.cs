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
    
    public partial class correoElectronico
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "Fecha")]
        public System.DateTime fecha { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Estatus")]
        public bool estatus { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Campo autogenerado")]
        public int campoAutogenerado { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "ID Usuario")]
        public int idUsuario_FK { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "ID Correo")]
        public int idCorreoElectronico { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
