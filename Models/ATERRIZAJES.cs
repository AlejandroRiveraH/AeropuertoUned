//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AeropuertoUned.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ATERRIZAJES
    {
        public string Id { get; set; }
        public string Fecha_Despegue { get; set; }
        public string Hora_Despegue { get; set; }
        public string Tecnico { get; set; }
        public string Mision { get; set; }
        public string Serie { get; set; }
        public string Fecha_Retorno { get; set; }
        public string Hora_Retorno { get; set; }
        public string Perdido { get; set; }
        public string Perdidas_Humanas { get; set; }
        public string Rescate { get; set; }
    }
}
