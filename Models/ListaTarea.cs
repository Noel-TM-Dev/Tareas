using System;
using System.Collections.Generic;

namespace Tareas.Models
{
    public partial class ListaTarea
    {
        public int ListaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public DateTime? FechaInit { get; set; }
        public DateTime? FechaFin { get; set; }
        /// <summary>
        /// I iniciada / F finalizada
        /// </summary>
        public string? Estatus { get; set; }
    }
}
