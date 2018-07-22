using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhalosBoutique.DAL.Interfaces;
using KhalosBoutique.DAL.Metodos;
using KhalosBoutique.DATA;

namespace KhalosBoutique.UI
{
    public partial class frmCategoria : Form
    {
        ICategoria cat;

        public frmCategoria()
        {
            cat = new MCategoria();
            InitializeComponent();
        }

        void ActualizarGridView()
        {
            dgvCategorias.DataSource = cat.ListarCategorias();
            btnModificar.Enabled = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var ct = txtNombre.Text;
                if (!String.IsNullOrEmpty(ct))
                {
                    var categoria = new Categoria
                    {

                        Nombre = txtNombre.Text,
                    };
                    cat.AgregarCategoria(categoria);
                    MessageBox.Show("Categoría insertada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    ActualizarGridView();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Faltan datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ActualizarGridView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrio el siguiente error: {0}",
                  ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInventarioAdministrar nav = new frmInventarioAdministrar();
            nav.Show();
            Hide();
        }

        private void btnBuscarAdmi_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = cat.BuscarCategoria(Convert.ToInt32(txtIdCategoriaAdmi.Text));
                if (categoria != null)
                {
                    txtNombreAdmi.Text = categoria.Nombre;
                    txtIdCategoriaAdmi.Enabled = false;
                    btnModificar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Categoría no existe", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrio el siguiente error: {0}",
                   ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = new Categoria
                {
                    IdCategoria = Convert.ToInt32(txtIdCategoriaAdmi.Text),
                    Nombre = txtNombreAdmi.Text,
                };
                cat.ActualizarCategoria(categoria);
                MessageBox.Show("Categoría insertada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGridView();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrio el siguiente error: {0}",
                  ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Limpiar()
        {
            txtIdCategoriaAdmi.Clear();
            txtNombreAdmi.Clear();
            txtIdCategoriaAdmi.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            var CargarCategorias = cat.ListarCategorias();
            dgvCategorias.DataSource = CargarCategorias;
        }
    }
    }
