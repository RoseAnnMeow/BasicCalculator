using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        GetAnswer delegateAddition, delegateSubtraction, delegateMultiplication, delegateDivision;
        double num1, num2;
         
        public Form1()
        {
            InitializeComponent();

            delegateAddition = new GetAnswer(Formulas.getSum);
            delegateSubtraction = new GetAnswer(Formulas.getMinus);
            delegateMultiplication = new GetAnswer(Formulas.getProduct);
            delegateDivision = new GetAnswer(Formulas.getQuotient);
        }
        public void Value()
        {
            num1 = Double.Parse(txtNum1.Text);
            num2 = Double.Parse(txtNum2.Text);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Value();
            MessageBox.Show("Answer: " + delegateAddition(num1,num2).ToString());
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            Value();
            MessageBox.Show("Answer: " + delegateSubtraction(num1, num2).ToString());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Value();
            MessageBox.Show("Answer: " + delegateMultiplication(num1, num2).ToString());
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Value();
            MessageBox.Show("Answer: " + delegateDivision(num1, num2).ToString());
        }
    }
}
