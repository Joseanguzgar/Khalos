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
    public partial class frmCompra : Form
    {
        IProducto prod;
        IDetalle_Factura fac;
        IFactura fact;
        List<Detalle_Factura> listaDetalle = new List<Detalle_Factura>(); 
        int precio;
        int catidad;
        int Total;


        public frmCompra()
        {
           MDetalle_Factura fac = new MDetalle_Factura();
            prod = new MProducto();
            fact = new MFactura();
            InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            var factura = fact.ListarFacturas();
            var factura2 = factura.Last();
            var factura3 = new Factura
            {
                Id_Factura = factura2.Id_Factura,
                Id_Cliente = factura2.Id_Cliente,
                Fecha = factura2.Fecha,
                PrecioTotal = Total
            };
            fact.ActualizarFactura(factura3);
            factura = null;
            frmPago form = new frmPago();
            form.Show();
            Hide();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(txtIdProducto.Text);

                var producto = prod.BuscarProductoId(idProducto); 

                catidad = (int)nudCantidad.Value;

                if (producto != null)
                {
                    if (catidad != 0)
                    {
                        if (producto.Cantidad_Stock > 0)
                        {
                            if (catidad <= producto.Cantidad_Stock) 
                            {
                                precio = Convert.ToInt32(producto.PrecioDetalle);


                                var factura = fact.ListarFacturas();
                                var factura2 = factura.Last();

                                Total = Total + (precio * catidad);

                                var Detalle = new Detalle_Factura 
                                {
                                    Id_Factura = factura2.Id_Factura,
                                    Id_Producto = Convert.ToInt32(txtIdProducto.Text),
                                    Cantidad = (int)nudCantidad.Value,
                                    Precio = precio,
                                };
                                fac.FacturarConjunto(Detalle);
                                prod.comprarProducto(idProducto, catidad);
                                listaDetalle = fac.ListarCompra(factura2.Id_Factura);
                                dgvFactura.DataSource = listaDetalle.ToList(); 
                                dgvProductos.DataSource = null;
                                dgvProductos.DataSource = prod.ListarProductosViewStock();

                            }
                            else { MessageBox.Show("La cantidad solicitada no existe en nuestro stock. Tenemos disponibles " + catidad + " artículos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                        }
                        else { MessageBox.Show("No existen en stock este producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    }
                    else { MessageBox.Show("La cantidad a comprar no puede ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("El producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                txtIdProducto.Clear();
                nudCantidad.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
