using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre es  Requerido")]
        [MaxLength(60,ErrorMessage ="Nombredebe ser Maximo 60 Caracteres")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es Requerida")]
        [MaxLength(100, ErrorMessage = "Descripcion debe ser Maximo 100 Caracteres")]
        public required string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es Requerido")]
        public bool Estado { get; set; }
    }
}
