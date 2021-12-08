using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tivi
{
    public partial class CalculatorUserControl : UserControl
    {
        private const string divideByZero = "Error!";
        private const string syntaxError = "SYNTAX ERROR!";

        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            None
        }
        Operation previousOperation = Operation.None;
        Operation currentOperation = Operation.None;

        public CalculatorUserControl()
        {
            InitializeComponent();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(displayTextBox.Text)) 
                return;
            Clipboard.SetText(displayTextBox.Text);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            PreCheck_ButtonClick();
            previousOperation = Operation.None;
            displayTextBox.Clear();
        }

        private void PreCheck_ButtonClick()
        {
            if (displayTextBox.Text == divideByZero || displayTextBox.Text == syntaxError)
                displayTextBox.Clear();
        }

        private void clearButon_Click(object sender, EventArgs e)
        {
            PreCheck_ButtonClick();
            if (displayTextBox.Text.Length > 0)
            {
                double d;
                if (!double.TryParse(displayTextBox.Text[displayTextBox.Text.Length - 1].ToString(), out d))
                {
                    previousOperation = Operation.None;
                }

                displayTextBox.Text = displayTextBox.Text.Remove(displayTextBox.Text.Length - 1, 1);
            }
            if (displayTextBox.Text.Length == 0)
            {
                previousOperation = Operation.None;
            }

        }

        private void zeroButton_Click(object sender, EventArgs e)  // will reuse this method to other button numbers
        {
            if (displayTextBox.Text == syntaxError || displayTextBox.Text == divideByZero)
            {
                displayTextBox.Text = string.Empty;
            }
            EnableOperatorButtons();
            PreCheck_ButtonClick();

            displayTextBox.Text += (sender as Button).Text;

        }

        private void EnableOperatorButtons(bool enable = true)
        {
            multiplyButton.Enabled = enable;
            divideButton.Enabled = enable;
            addButton.Enabled = enable;
            subtractButton.Enabled = enable;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (displayTextBox.TextLength == 0) 
                return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Divide;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            displayTextBox.Text += (sender as Button).Text;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (displayTextBox.TextLength == 0) 
                return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Multiply;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            displayTextBox.Text += (sender as Button).Text;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {

            if (displayTextBox.TextLength == 0 || previousOperation == Operation.Subtract) 
                return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Subtract;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            displayTextBox.Text += (sender as Button).Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (displayTextBox.TextLength == 0) 
                return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Add;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            displayTextBox.Text += (sender as Button).Text;
        }

        private void PerformCalculation(Operation previousOperation)
        {
            try
            {
                if (previousOperation == Operation.None)
                    return;
                List<double> numsList = null;

                switch (previousOperation)
                {
                    case Operation.Add:
                        if (currentOperation == Operation.Subtract)
                        {
                            currentOperation = Operation.Add;
                            return;
                        }
                        numsList = displayTextBox.Text.Split('+').Select(double.Parse).ToList();
                        displayTextBox.Text = (numsList[0] + numsList[1]).ToString();
                        break;
                    case Operation.Subtract:
                        int idx = displayTextBox.Text.LastIndexOf('-'); // To handle ex: -9-2
                        if (idx > 0)
                        {
                            var op1 = Convert.ToDouble(displayTextBox.Text.Substring(0, idx));
                            var op2 = Convert.ToDouble(displayTextBox.Text.Substring(idx + 1));
                            displayTextBox.Text = (op1 - op2).ToString();
                        }
                        break;
                    case Operation.Multiply:
                        if (currentOperation == Operation.Subtract)
                        {
                            currentOperation = Operation.Multiply;
                            return;
                        }
                        numsList = displayTextBox.Text.Split('*').Select(double.Parse).ToList();
                        displayTextBox.Text = (numsList[0] * numsList[1]).ToString();
                        break;
                    case Operation.Divide:
                        if (currentOperation == Operation.Subtract)
                        {
                            currentOperation = Operation.Divide;
                            return;
                        }
                        try
                        {
                            numsList = displayTextBox.Text.Split('/').Select(double.Parse).ToList();
                            if (numsList[1] == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            displayTextBox.Text = (numsList[0] / numsList[1]).ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            displayTextBox.Text = divideByZero;
                        }
                        break;
                    case Operation.None:
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                displayTextBox.Text = syntaxError;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (displayTextBox.TextLength == 0) 
                return;
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.None;

        }

    }
}
