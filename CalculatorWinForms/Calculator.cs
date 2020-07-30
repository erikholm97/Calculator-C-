using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void CalculatorTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = true;
            foreach (char isChar in CalculatorTextBox.Text)
            {
                if (Char.IsLetter(isChar))
                {
                    CalculatorTextBox.Text = CalculatorTextBox.Text.Remove(CalculatorTextBox.Text.Length - 1);
                }
            }
           
            
        }

        private void CalculatorLabelText_Click(object sender, EventArgs e)
        {
            
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void CeButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text = string.Empty;
        }

        private void CbuttonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text = string.Empty;
        }

        private void DelButtonClick(object sender, EventArgs e)
        {
                CalculatorTextBox.Text = CalculatorTextBox.Text.Remove(CalculatorTextBox.Text.Length - 1);
        }

        private void DivideButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '/';
        }

        private void SevenButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '7';
        }

        private void EightButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '8';
        }

        private void NineButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '9';
        }

        private void MultiplyButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '*';
        }

        private void FourButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '4';
        }

        private void FiveButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '5';
        }

        private void SixButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '6';
        }

        private void MinusButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '-';
        }

        private void ThreeButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '3';
        }

        private void TwoButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '2';
        }

        private void OneButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '1';
        }

        private void PlusButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '+';
        }

        private void CEButtonClick(object sender, EventArgs e)
        {
            
        }

        private void ZeroButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '0';
        }

        private void DotButtonClick(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += '.';
        }

        private void EqualsButtonClick(object sender, EventArgs e)
        {
            string value = new DataTable().Compute(CalculatorTextBox.Text, null).ToString();
            CalculatorLabel.Text = value;
        }
        private void EqualsMethod() { 
        }
    }
}
