namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInssL.Enabled = false;   //para no ingresar
            txtInssP.Enabled = false;
        }

        //private void btnCalcular_Click(object sender, EventArgs e)
        //{
        //    double ingr, il, ip;
        //    ingr = double.Parse(txtIngresos.Text);

        //    if (ingr > 4800 && ingr <= 500000)
        //    {
        //        il = ingr * 0.07;
        //        txtInssL.Text = il.ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Rango entre 4800 y 500000", "ERROR");
        //    }

        //}

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtIngresos.Text = "";
            txtInssL.Text = "";
            txtInssP.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cboTipD_SelectedIndexChanged(object sender, EventArgs e)
        {
            double ingr, il, ip;
            ingr = double.Parse(txtIngresos.Text);

            if (cboTipD.SelectedIndex == 0)
            {
                if (ingr > 4800 && ingr <= 500000)
                {
                    il = ingr * 0.07;
                    txtInssL.Text = il.ToString();
                }
                else
                {
                    MessageBox.Show("Rango entre 4800 y 500000", "ERROR");
                }
            }
            else if (cboTipD.SelectedIndex == 1)
            {
                if (ingr > 4800 && ingr <= 500000)
                {
                    ip = ingr * 0.07;
                    txtInssP.Text = ip.ToString();
                }
                else
                {
                    MessageBox.Show("Rango entre 4800 y 500000", "ERROR");
                }
            }
        }
       /*******************************************************************************************/
        //public void CalculoInssL()
        //{
        //    double ingr, il;
        //    ingr = double.Parse(txtIngresos.Text);

        //    if (ingr > 4800 && ingr <= 500000)
        //    {
        //        il = ingr * 0.07;
        //        txtInssL.Text = il.ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Rango entre 4800 y 500000", "ERROR");
        //    }
        //}

        //public void CalculoInssP()
        //{
        //    double ingr, ip;
        //    ingr = double.Parse(txtIngresos.Text);

        //    if (ingr > 4800 && ingr <= 500000)
        //    {
        //        ip = ingr * 0.07;
        //        txtInssP.Text = ip.ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Rango entre 4800 y 500000", "ERROR");
        //    }
        //}    
    }
}