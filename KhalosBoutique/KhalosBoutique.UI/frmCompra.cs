using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhalosBoutique.UI
{
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmar = MessageBox.Show("¿Seguro que desea volver?", "Confirmar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (confirmar == DialogResult.Yes)
                {
                    frmFactura nav = new frmFactura();
                    nav.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrió el siguiente error: {0}", ex.Message),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
