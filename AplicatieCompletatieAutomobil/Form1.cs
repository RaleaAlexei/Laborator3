namespace AplicatieCompletatieAutomobil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double InitialCarSum = 240000;
        private void btCalculeaza_Click(object sender, EventArgs e)
        {
            double ExtraPrice = 0;
            int ModificationsAdded = 0;
            if (cbAbs.Checked)
            {
                ExtraPrice += 8000;
                ModificationsAdded++;
            }
            if (cbParctronic.Checked)
            {
                ExtraPrice += 20000;
                ModificationsAdded++;
            }
            if (cbSecuritate.Checked)
            {
                ExtraPrice += 12000;
                ModificationsAdded++;
            }
            if (cbTire.Checked)
            {
                ExtraPrice += 2000;
                ModificationsAdded++;
            }
            if (cbMotor.Checked)
            {
                ExtraPrice += 10000;
                ModificationsAdded++;
            }
            if (cbLocuri.Checked)
            {
                ExtraPrice += 1000;
                ModificationsAdded++;
            }
            double TotalPrice = InitialCarSum + ExtraPrice;
            string Result = $"Costul complectatiei selectate este {TotalPrice} lei";
            if(ModificationsAdded >= 3 && ModificationsAdded < 6)
            {
                ExtraPrice *= 0.1;
                TotalPrice -= ExtraPrice;
                Result = $"Reducere (10%): {ExtraPrice} lei\nTotal: {TotalPrice} lei";
            }
            else if(ModificationsAdded == 6)
            {
                ExtraPrice *= 0.25;
                TotalPrice -= ExtraPrice;
                Result = $"Reducere (25%): {ExtraPrice} lei\nTotal: {TotalPrice} lei";
            }
            labelResult.Text = Result;
        }

        private void modcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            labelResult.Text = String.Empty;
        }
    }
}