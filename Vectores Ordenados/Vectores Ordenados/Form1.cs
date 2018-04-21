using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_Ordenados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Inventario inventario = new Inventario();
        Auto autoN;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Agregar
        {
            autoN = new Auto();
            if (inventario.cantidad < 15)
            {
                Leer();

                inventario.Buscar(autoN.placa);
                if (inventario.validar)
                {
                    MessageBox.Show("Placas iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    inventario.Agregar(autoN);
                }
            }
            else
            {
                MessageBox.Show("Lugares ocupados", "Espacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)//Buscar
        {
            string placa = txtPlacas.Text;
            Auto tem;
            tem = inventario.Buscar(placa);
            if (tem != null)
            {
                txtList.Text = tem.ToString();
            }
            else
            {
                MessageBox.Show("Auto no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)//Eliminar
        {
            string placa = txtPlacas.Text;
            inventario.Eliminar(placa);
        }

        private void btnListar_Click(object sender, EventArgs e)//Listar
        {
            inventario.Lista();
            txtList.Text = inventario.ToString();
        }
        private void _borrar()
        {
            txtModelo.Clear();
            txtFecha.Clear();
            txtPlacas.Clear();
            txtTelefono.Clear();

        }
        private void Leer()
        {

            autoN.modelo = txtModelo.Text;
            autoN.fecha = txtFecha.Text;
            autoN.placa = txtPlacas.Text;
            autoN.telefono = txtTelefono.Text;

        }
    }
}
        /*autoN = new Auto();
txtPosicion.Value = inventario.cantidad + 2;
if (inventario.cantidad < 15)
{
leer();
inventario.Agregar(autoN);
Borrar();
}
else
{
MessageBox.Show("LLeno", "Espacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
}*/
  