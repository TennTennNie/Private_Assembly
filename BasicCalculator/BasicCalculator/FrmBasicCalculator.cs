using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        BasicComputation basic = new BasicComputation();

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int Input1 = int.Parse(txtInput1.Text);
            int Input2 = int.Parse(txtInput2.Text);

            if(comboBox1.Text == "+")
            {
                float result = basic.Addition(Input1, Input2);
                lblTotal.Text = result.ToString();
            }
            else if(comboBox1.Text == "-")
            {
                float result = basic.Subtraction(Input1, Input2);
                lblTotal.Text = result.ToString();
            }
            else if(comboBox1.Text == "*")
            {
                float result = basic.Multiplication(Input1, Input2);
                lblTotal.Text = result.ToString();
            }
            else if(comboBox1.Text == "/")
            {
                float result = basic.Divition(Input1, Input2);
                lblTotal.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
