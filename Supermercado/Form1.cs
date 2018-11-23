using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabla();
            mostrarVenta();
            mostrarcliente();
            mostrarProovedor();
            mostrarVendedor();
            mostrarCompra();
        }
        private void tabla()
        {
            dataGridView1.DataSource = Controladoproducto.CargarDatosProductos();


        }

        private void mostrarcliente()
        {
            dataGridView2.DataSource = controladorCliente.CargarDatosClientes();


        }
        private void mostrarProovedor()
        {
            dataGridView3.DataSource = controlador_proovedor.CargarDatosProovedores();


        }
        private void mostrarVenta()
        {
            dataGridView4.DataSource = Controladorventa.CargarDatosVentas();


        }
        private void mostrarVendedor()
        {
            dataGridView5.DataSource = Controladorvendedor.CargarDatosVendedores();


        }
        private void mostrarCompra()
        {
            dataGridView6.DataSource = ControladorCompra.CargarDatosCompras();


        }


        private void button2_Click(object sender, EventArgs e)
        {
            producto_form producto_form = new producto_form();
            producto_form.Show();
            tabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cliente_form cliente_form = new cliente_form();
            cliente_form.Show();
            mostrarcliente();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proovedor_Form Proovedor_form = new Proovedor_Form();
            Proovedor_form.Show();
            mostrarProovedor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            venta_form venta_form = new venta_form();
            venta_form.Show();
            mostrarVenta();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vendedor_form vendedor_form = new vendedor_form();
            vendedor_form.Show();
            mostrarVendedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compra_form compra_form = new compra_form();
            compra_form.Show();
            mostrarCompra();
        }
    }
}
