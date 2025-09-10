namespace Calculator
{
    public partial class Calculator : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox.Text = currentInput;
        }

        private void Evaluate()
        {
            if (double.TryParse(currentInput, out double number))
            {
                switch (operation)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                    case "x":
                        result *= number;
                        break;
                    case "/":
                        if (number != 0)
                            result /= number;
                        else
                            MessageBox.Show("Cannot divide by zero");
                        break;
                    case "%":
                        if (number != 0)
                            result %= number;
                        else
                            MessageBox.Show("Cannot modulo by zero");
                        break;
                    default:
                        result = number;
                        break;
                }
                TxtBox.Text = result.ToString();
                currentInput = "";
                operationPending = false;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }
            operationPending = true;
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            if (!operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }
            operationPending = true;
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            if (!operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }
            operationPending = true;
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            if (!operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }
            operationPending = true;
        }

        private void ModuloBtn_Click(object sender, EventArgs e)
        {
            if (!operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }
            operationPending = true;
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                if (string.IsNullOrEmpty(currentInput))
                {
                    currentInput = "0.";
                }
                else
                {
                    currentInput += ".";
                }
                TxtBox.Text = currentInput;
            }
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            TxtBox.Text = "0";
        }


    }
}
