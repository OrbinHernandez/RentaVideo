using Capa_Datos.Modelos;
using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class NRenta
    {
        private readonly DRenta _dRenta;

        public NRenta()
        {
            _dRenta = new DRenta();
        }

        public List<Renta> ObtenerTodasLasRentas()
        {
            return _dRenta.ObtenerTodasLasRentas();
        }

        public int GuardarRenta(Renta renta)
        {
            if (renta.RentaId == 0)
            {
                return _dRenta.AgregarRenta(renta);
            }
            else
            {
                return _dRenta.EditarRenta(renta);
            }
        }

        public int EliminarRenta(int rentaId)
        {
            return _dRenta.EliminarRenta(rentaId);
        }
    }
}
