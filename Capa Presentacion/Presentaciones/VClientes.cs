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
    public partial class VClientes : Form
    {
        NClientes nClientes;
        public VClientes()
        {
            InitializeComponent();
            nClientes = new NClientes();
        }
        private void Limpiar()
        {
            LblId.Text = "0";
            TxtNombre.Text = "";
            TxtApellidos.Text = "";
            ChkActivo.Checked = false;
            errorProvider1.Clear();
        }
        private void Guardar()
        {
            string clienteId = LblId.Text;
            string nombres = TxtNombre.Text;
            string apellidos = TxtApellidos.Text;;

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrWhiteSpace(nombres))
            {
                errorProvider1.SetError(TxtNombre, "Debe ingresar el nombre del cliente.");
                return;
            }

            var cliente = new Clientes();
            if (int.Parse(clienteId) != 0)
            {
                cliente.ClienteId = int.Parse(clienteId);
            }
            cliente.Nombres = nombres;
            cliente.Apellidos = apellidos;
            cliente.Estado = ChkActivo.Checked;

            nClientes.GuardarCliente(cliente);
            Cargar();
            Limpiar();
        }
        private void Cargar()
        {
            DgvDatos.DataSource = nClientes.ObtenerTodosLosClientes();
        }
        private void Editar()
        {
            if (DgvDatos.SelectedCells.Count > 0)
            {
                int rowIndex = DgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DgvDatos.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    if (DgvDatos.Rows[rowIndex].Cells["ClienteId"].Value is int id)
                    {
                        ConsultarPorId(id);
                    }
                }
            }
        }
        private void ConsultarPorId(int idCliente)
        {
            var cliente = nClientes.ObtenerTodosLosClientes().FirstOrDefault(c => c.ClienteId == idCliente);
            if (cliente != null)
            {
                LblId.Text = cliente.ClienteId.ToString();
                TxtNombre.Text = cliente.Nombres;
                TxtApellidos.Text = cliente.Apellidos;
                ChkActivo.Checked = cliente.Estado;
            }
        }
        private void Eliminar()
        {
            if (DgvDatos.SelectedCells.Count > 0)
            {
                int rowIndex = DgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DgvDatos.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    if (DgvDatos.Rows[rowIndex].Cells["ClienteId"].Value is int id)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nClientes.EliminarCliente(id);
                            Cargar();
                            Limpiar();
                        }
                    }
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void VClientes_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
