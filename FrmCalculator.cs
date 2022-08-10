namespace TP.Aula02
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height, weight;
            weight = Convert.ToDouble(TxbWeight.Text);
            height = Convert.ToDouble(TxbHeight.Text);

            var (IMCdescription, IMCresult) = CalcularIMC(weight, height / 100);

            LblReturn.Text = $"{IMCdescription}\nSeu IMC é de {Math.Round(IMCresult,2)}";
        }

        private (string, double) CalcularIMC(double weight, double height)
        {
            double IMC = weight / (height * height);

            var result = IMC switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
                // underscore é um símbolo do valor default
            };

            return (result, IMC);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // LblTitle.Text = "Calculadora\ndeIMC";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void BtmClean_Click(object sender, EventArgs e)
        {
            TxbHeight.Text = String.Empty;
            TxbWeight.Text = String.Empty;
            LblReturn.Text = String.Empty;
          
        }

        private void TxbWeight_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}