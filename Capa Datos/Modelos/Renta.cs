using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Modelos
{
    public class Renta
    {
        [Key]
        public int RentaId { get; set; }

        [Required]
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; }

        [Required]
        [ForeignKey("Pelicula")]
        public int PeliculaID { get; set; }
        public Peliculas Pelicula { get; set; }

        [Required]
        public DateTime FechaRenta { get; set; }

        [Required]
        public DateTime FechaRetorno { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PrecioRenta { get; set; }
    }
}
