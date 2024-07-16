using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppBlazorCRUD.Data
{
    public partial class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres")]
        public string Apellido { get; set; } = null!;
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        public string? Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }
    }
}
