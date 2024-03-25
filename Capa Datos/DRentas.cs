using Capa_Datos.Core;
using Capa_Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DRenta
    {
        private readonly UnitOfWork _unitOfWork;

        public DRenta()
        {
            _unitOfWork = new UnitOfWork();
        }

        public List<Renta> ObtenerTodasLasRentas()
        {
            return _unitOfWork.Repository<Renta>().Consulta().ToList();
        }

        public int AgregarRenta(Renta renta)
        {
            renta.FechaRenta = DateTime.Now; // Asumiendo que la fecha de renta se establece al agregar
                                             // Nota: FechaRetorno podría necesitar ser manipulada de forma diferente dependiendo de la lógica del negocio
            _unitOfWork.Repository<Renta>().Agregar(renta);
            return _unitOfWork.Guardar();
        }

        public int EditarRenta(Renta renta)
        {
            var rentaInDb = _unitOfWork.Repository<Renta>().Consulta().FirstOrDefault(r => r.RentaId == renta.RentaId);

            if (rentaInDb != null)
            {
                rentaInDb.FechaRetorno = renta.FechaRetorno; // Ejemplo de campo que podría querer ser actualizado
                rentaInDb.Cantidad = renta.Cantidad;
                rentaInDb.PrecioRenta = renta.PrecioRenta;
                // Actualizar otros campos según sea necesario

                _unitOfWork.Repository<Renta>().Editar(rentaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

        public int EliminarRenta(int rentaId)
        {
            var rentaInDb = _unitOfWork.Repository<Renta>().Consulta().FirstOrDefault(r => r.RentaId == rentaId);

            if (rentaInDb != null)
            {
                _unitOfWork.Repository<Renta>().Eliminar(rentaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
