using Capa_Datos.Modelos;
using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class NPeliculas
    {
        private readonly DPeliculas dPeliculas;

        public NPeliculas()
        {
            dPeliculas = new DPeliculas();
        }

        public List<Peliculas> ObtenerTodasLasPeliculas()
        {
            return dPeliculas.TodasLasPeliculas();
        }

        public List<Peliculas> ObtenerPeliculasActivas()
        {
            var peliculas = dPeliculas.TodasLasPeliculas();
            return peliculas.Where(p => p.Estado == true).ToList();
        }

        public int GuardarPelicula(Peliculas pelicula)
        {
            if (pelicula.PeliculaID == 0)
            {
                return dPeliculas.Agregar(pelicula);
            }
            else
            {
                return dPeliculas.Editar(pelicula);
            }
        }

        public int EliminarPelicula(int peliculaID)
        {
            return dPeliculas.Eliminar(peliculaID);
        }
    }
}
