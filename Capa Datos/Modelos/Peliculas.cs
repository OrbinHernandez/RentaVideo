using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Modelos
{
    public class Peliculas
    {
        [Key]
        public int PeliculaID { get; set; }

        [Required]
        [StringLength(75)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string Genero { get; set; }

        [Required]
        [StringLength(75)]
        public string Autores { get; set; }

        [Required]
        public int Existencia { get; set; }

        [Required]
        public decimal PrecioRenta { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}
