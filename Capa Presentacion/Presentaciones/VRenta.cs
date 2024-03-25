using Capa_Datos;
using Capa_Datos.Modelos;
using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class VRenta : Form
    {
        NRenta nRenta;
        NClientes nClientes;
        NPeliculas nPeliculas;
        public VRenta()
        {
            InitializeComponent();
            nRenta = new NRenta();
            nClientes = new NClientes();
            nPeliculas = new NPeliculas();
        }

        void Limpiar()
        {
            TxtRentaid.Text = "";
            TxtPrecioRenta.Text = "";
            TxtCantidad.Text = "";
            CmbClienteId.SelectedValue = -1;
            CmbPeliculaId.SelectedValue = -1;
        }

        void guardar()
        {
            string Rentaid = TxtRentaid.Text;
            string Cantidad = TxtCantidad.Text;
            string PrecioRenta = TxtPrecioRenta.Text;
            int ClienteId = Convert.ToInt32(CmbClienteId.SelectedValue);
            int PeliculaId = Convert.ToInt32(CmbPeliculaId.SelectedValue);
            DateTime FechaRetorno = DtFechaRetorno.Value;
            if (string.IsNullOrEmpty(PrecioRenta) || string.IsNullOrWhiteSpace(PrecioRenta))
            {
                errorProvider1.SetError(TxtPrecioRenta, "Debe colocar precio de renta");
                return;
            }

            if (string.IsNullOrEmpty(Cantidad) || string.IsNullOrWhiteSpace(Cantidad))
            {
                errorProvider1.SetError(TxtCantidad, "Debe colocar la cantidad");
                return;
            }
            if (string.IsNullOrEmpty(Rentaid) || string.IsNullOrWhiteSpace(Rentaid))
            {
                Rentaid = "0";
            }
            var renta = new Renta();
            if (int.Parse(Rentaid) != 0)
            {
                renta.ClienteId = int.Parse(Rentaid);
            }
            renta.RentaId= int.Parse(Rentaid);
            renta.Cantidad = int.Parse(Cantidad);
            renta.PrecioRenta = decimal.Parse(PrecioRenta);
            renta.ClienteId = ClienteId;
            renta.PeliculaID = PeliculaId;
            renta.FechaRetorno= FechaRetorno;
            nRenta.GuardarRenta(renta);

            Cargar();
            Limpiar();
        }
        private void ConsultarPorId(int idRenta)
        {
            var renta = nRenta.ObtenerTodasLasRentas().FirstOrDefault(r => r.RentaId == idRenta);
            if (renta != null)
            {
                TxtRentaid.Text = renta.RentaId.ToString();
                CmbClienteId.Text = renta.ClienteId.ToString();
                CmbPeliculaId.Text = renta.PeliculaID.ToString();
                DtFechaRetorno.Value = renta.FechaRetorno;
                TxtCantidad.Text = renta.Cantidad.ToString();
                TxtPrecioRenta.Text = renta.PrecioRenta.ToString();
            }
        }

        private void Editar()
        {
            if (DGVRentas.SelectedCells.Count > 0)
            {
                int rowIndex = DGVRentas.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DGVRentas.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    // Obtener el ID directamente de la celda
                    if (DGVRentas.Rows[rowIndex].Cells["RentaId"].Value is int id)
                    {
                        ConsultarPorId(id);
                    }
                }
            }
        }
        private void Eliminar()
        {
            if (DGVRentas.SelectedCells.Count > 0)
            {
                int rowIndex = DGVRentas.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DGVRentas.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    // Obtener el ID directamente de la celda
                    if (DGVRentas.Rows[rowIndex].Cells["RentaId"].Value is int id)
                    {
                        var renta = nRenta.ObtenerTodasLasRentas().FirstOrDefault(r => r.RentaId == id);
                        if (renta != null)
                        {
                            string mensaje = $"¿Está seguro de eliminar la renta ID: {renta.RentaId}?";
                            DialogResult resultado = MessageBox.Show(mensaje, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (resultado == DialogResult.Yes)
                            {
                                nRenta.EliminarRenta(id);
                                Cargar();
                                Limpiar();
                            }
                        }
                    }
                }
            }
        }
        void Combo()
        {
            try
            {
                var clientes = nClientes.ObtenerTodosLosClientes();
                var peliculas = nPeliculas.ObtenerTodasLasPeliculas();

                if (clientes != null && clientes.Any() && peliculas != null && peliculas.Any())
                {
                    CmbClienteId.DataSource = clientes;
                    CmbClienteId.DisplayMember = "Nombres";
                    CmbClienteId.ValueMember = "ClienteId";

                    CmbPeliculaId.DataSource = peliculas;
                    CmbPeliculaId.DisplayMember = "Nombre";
                    CmbPeliculaId.ValueMember = "PeliculaID";
                }
                else
                {
                    MessageBox.Show("No hay clientes o películas disponibles. Debe agregar clientes y películas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al cargar los clientes o películas: {ex.Message}");
            }
        }
        void Cargar()
        {
            DGVRentas.DataSource = nRenta.ObtenerTodasLasRentas();
        }

        private void Renta_Load(object sender, EventArgs e)
        {
            Cargar();
            Combo();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar(); 
        }
    }
}
