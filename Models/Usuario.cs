using System;
using System.Collections.Generic;

namespace Tareas.Models
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string Username { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Estatus { get; set; }
    }
}
