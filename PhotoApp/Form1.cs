namespace PhotoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculeaza_Click(object sender, EventArgs e)
        {
            double Pret = 0;
            int n = 0;
            double sum = 0;
            if (radioS1.Checked)
            {
                Pret = 8.5;
            }
            if (radioS2.Checked)
            {
                Pret = 10;
            }
            if (radioS3.Checked)
            {
                Pret = 15.5;
            }
            if (radioS4.Checked)
            {
                Pret = 12;
            }
            if (radioS5.Checked)
            {
                Pret = 15;
            }
            if (radioS6.Checked)
            {
                Pret = 24;
            }
            int.TryParse(tbAmount.Text, out n);
            sum = n * Pret;
            labelResult.Text = $"Pretul: {Pret.ToString("c")}\nCantitatea: {n} fotografii.\nSuma comenzii: {sum.ToString("C")}";
        }

        private void radioS1_Click(object sender, EventArgs e)
        {
            labelResult.Text = String.Empty;
            tbAmount.Text = String.Empty;
            tbAmount.Focus();
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            btCalculeaza.Enabled = (tbAmount.Text.Length != 0);
            labelResult.Text = String.Empty;
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    btCalculeaza.Focus();
                }
                return;
            }

            e.Handled = true;
        }
    }
}