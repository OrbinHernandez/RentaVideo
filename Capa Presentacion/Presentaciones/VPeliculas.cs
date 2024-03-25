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
    public partial class VPeliculas : Form
    {
        NPeliculas nPeliculas;
        public VPeliculas()
        {
            InitializeComponent();
            nPeliculas = new NPeliculas();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void Limpiar()
        {
            LblId.Text = "0";
            TxtAutores.Text = "";
            TxtExistencia.Text = "";
            TxtNombre.Text = "";
            TxtPrecioRenta.Text = "";
            TxtGenero.Text = "";
            ChkActivo.Checked = false;
            errorProvider1.Clear();
        }
        void guardar()
        {
            string PeliculaId = LblId.Text;
            string Nombre = TxtNombre.Text;
            string Existencia = TxtExistencia.Text;
            string Autores = TxtAutores.Text;
            string Genero = TxtGenero.Text;
            string PrecioRenta = TxtPrecioRenta.Text;

            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrWhiteSpace(Nombre))
            {
                errorProvider1.SetError(TxtNombre, "Debe colocar la Nombre");
                return;
            }

            var pelicula = new Peliculas();
            if (int.Parse(PeliculaId) != 0)
            {
                pelicula.PeliculaID = int.Parse(PeliculaId);
            }
            pelicula.Genero= Genero;
            pelicula.Nombre = Nombre;
            pelicula.Existencia = int.Parse(Existencia);
            pelicula.Autores = Autores;
            pelicula.PrecioRenta = decimal.Parse(PrecioRenta);
            pelicula.Estado = ChkActivo.Checked;
            nPeliculas.GuardarPelicula(pelicula);
            cargar();
            Limpiar();
        }
        void cargar()
        {
            DgvDatos.DataSource = nPeliculas.ObtenerTodasLasPeliculas();
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        void Editar()
        {
            if (DgvDatos.SelectedCells.Count > 0)
            {
                int rowIndex = DgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DgvDatos.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    // Obtener el ID directamente de la celda
                    if (DgvDatos.Rows[rowIndex].Cells["PeliculaID"].Value is int id)
                    {
                        ConsultarPorID(id);
                    }
                }
            }
        }
        void ConsultarPorID(int IDPelicula)
        {
            var pelicula = nPeliculas.ObtenerTodasLasPeliculas().FirstOrDefault(g => g.PeliculaID == IDPelicula);
            if (pelicula != null)
            {
                LblId.Text = pelicula.PeliculaID.ToString();
                TxtNombre.Text = pelicula.Nombre;
                TxtAutores.Text = pelicula.Autores;
                TxtGenero.Text = pelicula.Genero;
                TxtExistencia.Text = pelicula.Existencia.ToString();
                TxtPrecioRenta.Text = pelicula.PrecioRenta.ToString();
                ChkActivo.Checked = pelicula.Estado;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        private void Eliminar()
        {
            if (DgvDatos.SelectedCells.Count > 0)
            {
                int rowIndex = DgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DgvDatos.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    // Obtener el ID directamente de la celda
                    if (DgvDatos.Rows[rowIndex].Cells["PeliculaID"].Value is int id)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nPeliculas.EliminarPelicula(id);
                            cargar();
                            Limpiar();
                        }
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
