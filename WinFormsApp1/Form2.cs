using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtUtilidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtUtilidad.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUtilidad.Text = "";
            txtIngreso.Text = "";
            txtEgreso.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ingr, ut, egr;
            ingr = double.Parse(txtIngreso.Text);
            egr = double.Parse(txtEgreso.Text);

            if (ingr > 4800 && ingr <= 500000)
            {
                if (egr > 0 && egr < ingr)
                {
                    ut = ingr - egr;
                    txtUtilidad.Text = ut.ToString();
                }
                else
                {
                    MessageBox.Show("EL egreso debe ser menor al ingreso", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Rango entre 4800 y 500000", "ERROR");
            }

        }

        private void True(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEgreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEgreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
