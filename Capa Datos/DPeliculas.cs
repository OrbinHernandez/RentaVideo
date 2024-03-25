using Capa_Datos.Core;
using Capa_Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DPeliculas
    {
        private readonly UnitOfWork _unitOfWork;

        public DPeliculas()
        {
            _unitOfWork = new UnitOfWork();
        }

        public List<Peliculas> TodasLasPeliculas()
        {
            return _unitOfWork.Repository<Peliculas>().Consulta().ToList();
        }

        public int Agregar(Peliculas pelicula)
        {
            _unitOfWork.Repository<Peliculas>().Agregar(pelicula);
            return _unitOfWork.Guardar();
        }

        public int Editar(Peliculas pelicula)
        {
            var peliculaInDb = _unitOfWork.Repository<Peliculas>().Consulta().FirstOrDefault(p => p.PeliculaID == pelicula.PeliculaID);

            if (peliculaInDb != null)
            {
                peliculaInDb.Nombre = pelicula.Nombre;
                peliculaInDb.Genero = pelicula.Genero;
                peliculaInDb.Autores = pelicula.Autores;
                peliculaInDb.Existencia = pelicula.Existencia;
                peliculaInDb.PrecioRenta = pelicula.PrecioRenta;
                peliculaInDb.Estado = pelicula.Estado;
                _unitOfWork.Repository<Peliculas>().Editar(peliculaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

        public int Eliminar(int peliculaID)
        {
            var peliculaInDb = _unitOfWork.Repository<Peliculas>().Consulta().FirstOrDefault(p => p.PeliculaID == peliculaID);

            if (peliculaInDb != null)
            {
                _unitOfWork.Repository<Peliculas>().Eliminar(peliculaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
