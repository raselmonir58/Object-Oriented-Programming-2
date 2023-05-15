namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string opPerformed = "";
        bool isOpPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isOpPerformed))
                textBox.Clear();

            isOpPerformed = false;
            Button n=(Button) sender;
            if(n.Text == ".")
            {
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text;
            }
            else
            textBox.Text = textBox.Text + n.Text;
            
        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if(resultValue !=0)
            {
                bequal.PerformClick();
                opPerformed = n.Text;
                lcurrentOp.Text = resultValue + " " + opPerformed;
                isOpPerformed = true;
            }
            else
            {
                opPerformed = n.Text;
                resultValue = Double.Parse(textBox.Text);
                lcurrentOp.Text = resultValue + " " + opPerformed;
                isOpPerformed = true;
            }
            
        }

        private void bce_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void bequal_click(object sender, EventArgs e)
        {
            switch(opPerformed)
                {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;

                default:
                    break;
            }
            resultValue = Double.Parse(textBox.Text);
            lcurrentOp.Text = "";
        }
    }
}