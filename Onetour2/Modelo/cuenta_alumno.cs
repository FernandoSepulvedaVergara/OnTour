//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Onetour2.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class cuenta_alumno
    {
        public int id_cuenta { get; set; }
        public int id_curso { get; set; }
        public int rut_alumno { get; set; }
        public int saldo { get; set; }
        public int monto_prorrateado { get; set; }
    
        public virtual alumno alumno { get; set; }
        public virtual curso curso { get; set; }
    }
}
