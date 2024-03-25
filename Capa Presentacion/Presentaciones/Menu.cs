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
    public partial class Menu : Form
    {
        AbrirEnMenu AF;
        public Menu()
        {
            InitializeComponent();
            AF = new AbrirEnMenu();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AF.Abrir(new VClientes(), pnlContenedor, true);
        }

        private void BtnPeliculas_Click(object sender, EventArgs e)
        {
            AF.Abrir(new VPeliculas(), pnlContenedor, true);
        }

        private void BtnRentas_Click(object sender, EventArgs e)
        {
            AF.Abrir(new VRenta(), pnlContenedor, true);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AF.Abrir(new Inicio(), pnlContenedor, true);
        }

        private void PtbLogo_Click(object sender, EventArgs e)
        {
            AF.Cerrar();
            AF.Abrir(new Inicio(), pnlContenedor, true);
        }
    }
}
