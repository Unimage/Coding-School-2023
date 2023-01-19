using Calculation;
using System.Diagnostics;


namespace Session_09 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
        }




        private void buttonSymbolEquals_Click(object sender, EventArgs e) {
            var calculation = new Calc();
            textBoxResult.Text = calculation.Calculate(textBoxResult.Text);
        }

        private void buttonNumberOne_Click(object sender, EventArgs e) {
            textBoxResult.Text += "1";
        }

        private void buttonNumberTwo_Click(object sender, EventArgs e) {
            textBoxResult.Text += "2";
        }

        private void buttonNumberThree_Click(object sender, EventArgs e) {
            textBoxResult.Text += "3";
        }

        private void buttonNumberFour_Click(object sender, EventArgs e) {
            textBoxResult.Text += "4";
        }

        private void buttonNumberFive_Click(object sender, EventArgs e) {
            textBoxResult.Text += "5";
        }

        private void buttonNumberSix_Click(object sender, EventArgs e) {
            textBoxResult.Text += "6";
        }

        private void buttonNumberSeven_Click(object sender, EventArgs e) {
            textBoxResult.Text += "7";
        }

        private void buttonNumberEight_Click(object sender, EventArgs e) {
            textBoxResult.Text += "8";
        }

        private void buttonNumberNine_Click(object sender, EventArgs e) {
            textBoxResult.Text += "9";
        }

        private void buttonSymbolDiv_Click(object sender, EventArgs e) {
            textBoxResult.Text += "/";
        }

        private void buttonSymbolPower_Click(object sender, EventArgs e) {
            textBoxResult.Text += "^";
        }

        private void buttonSymbolSqrt_Click(object sender, EventArgs e) {
            textBoxResult.Text += "s";
        }

        private void buttonSymbolClear_Click(object sender, EventArgs e) {
            textBoxResult.Text = string.Empty;
        }

        private void buttonSymbolComma_Click(object sender, EventArgs e) {
            textBoxResult.Text += ".";
        }

        private void buttonNumberZero_Click(object sender, EventArgs e) {
            textBoxResult.Text += "0";
        }

        private void buttonSymbolPlus_Click(object sender, EventArgs e) {
            textBoxResult.Text += "+";
        }

        private void buttonSymbolMinus_Click(object sender, EventArgs e) {
            textBoxResult.Text += "-";
        }

        private void buttonSymbolMulti_Click(object sender, EventArgs e) {
            textBoxResult.Text += "*";
        }
    }
}