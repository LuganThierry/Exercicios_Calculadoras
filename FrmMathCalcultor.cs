using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TP.Aula02
{
    public partial class FrmMathCalcultor : Form
    {
        public double Resultado { get; set; }
        public double Valor { get; set; }



        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Somar,
            Subtrair,
            Multiplicar,
            Dividir
        }


        public FrmMathCalcultor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Somar:
                    Resultado = Valor + Convert.ToDouble(TxbResult.Text);
                    break;
                case Operacao.Subtrair:
                    Resultado = Valor - Convert.ToDouble(TxbResult.Text);
                    break;
                case Operacao.Multiplicar:
                    Resultado = Valor * Convert.ToDouble(TxbResult.Text);
                    break;
                case Operacao.Dividir:
                    Resultado = Valor / Convert.ToDouble(TxbResult.Text);
                    break;
            }
            TxbOp.Text += $"{TxbResult.Text}";
            TxbResult.Text = Convert.ToString(Math.Round(Resultado, 3));
        }

        private void LblResult_Click(object sender, EventArgs e)
        {

        }

        private void TxbResult_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxbResult.Text = String.Empty;
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "1";
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "2";
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "3";
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "4";
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "5";
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "6";
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "8";
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "9";
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            TxbResult.Text += "0";
        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Somar;
            Valor = Convert.ToDouble(TxbResult.Text);
            TxbResult.Text = "";
            TxbOp.Text = $"{Valor} + ";

        }

        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtrair;
            Valor = Convert.ToDouble(TxbResult.Text);
            TxbResult.Text = "";
            TxbOp.Text = $"{Valor} - ";
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicar;
            Valor = Convert.ToDouble(TxbResult.Text);
            TxbResult.Text = "";
            TxbOp.Text = $"{Valor} x ";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Dividir;
            Valor = Convert.ToDouble(TxbResult.Text);
            TxbResult.Text = "";
            TxbOp.Text = $"{Valor} ÷ ";
        }

        private void BtnComma_Click(object sender, EventArgs e)
        {
            if (!TxbResult.Text.Contains(","))
            {
                TxbResult.Text += ",";
            }
        }

        private void FrmMathCalcultor_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
