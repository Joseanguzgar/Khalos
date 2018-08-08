using KhalosBoutique.DAL.Interfaces;
using KhalosBoutique.DAL.Metodos;
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
    public partial class frmPago : Form
    {
        IFactura fact;
        ICliente cli;
        IDetalle_Factura det;
        public frmPago()
        {
            cli = new MCliente();
            fact = new MFactura();
           MDetalle_Factura det = new MDetalle_Factura();
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            var factura = fact.ListarFacturas();
            var factura2 = factura.Last();

            double pago = (int)nudPago.Value;
            double total = factura2.PrecioTotal;


            if (pago >= total)
            {
                double vuelto = pago - total;
                MessageBox.Show("Total a pagar: " + total + ". Cancela con: " + pago + " .Su cambio es de: " + vuelto, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenuVendedor form = new frmMenuVendedor();
                form.Show();
                Hide();
            }
            else
            {
                double faltante = total - pago;
                MessageBox.Show("Cantidad insuficiente. Faltan: " + faltante + " para cancelar el total de la factura", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            var factura = fact.ListarFacturas();
            var factura2 = factura.Last();

            var cliente = cli.BuscarCliente(factura2.Id_Cliente);

            txtFecha.Text = factura2.Fecha.ToString();
            txtFactura.Text = factura2.Id_Factura.ToString();
            txtCliente.Text = cliente.Nombre;
            txtTotal.Text = factura2.PrecioTotal.ToString();
        }
    }
    }

