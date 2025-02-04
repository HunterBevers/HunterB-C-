namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            // Read input from the textboxes
            double number1 = double.Parse(First_Result.Text);
            double number2 = double.Parse(Second_Result.Text);

            // Perform Addition
            double result = number1 + number2;

            // Display the result in the third text box
            Third_Result.Text = result.ToString();
        }

        private void Subtract_Button_Click(object sender, EventArgs e)
        {
            // Read input from the textboxes
            double number1 = double.Parse(First_Result.Text);
            double number2 = double.Parse(Second_Result.Text);

            // Perform Addition
            double result = number1 - number2;

            // Display the result in the third text box
            Third_Result.Text = result.ToString();
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            // Read input from the textboxes
            double number1 = double.Parse(First_Result.Text);
            double number2 = double.Parse(Second_Result.Text);

            // Perform Addition
            double result = number1 * number2;

            // Display the result in the third text box
            Third_Result.Text = result.ToString();
        }

        private void Divide_Button_Click(object sender, EventArgs e)
        {
            // Read input from the textboxes
            double number1 = double.Parse(First_Result.Text);
            double number2 = double.Parse(Second_Result.Text);

            // Perform Addition
            double result = number1 / number2;

            // Display the result in the third text box
            Third_Result.Text = result.ToString();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to quit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void First_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void AC_Button_Click(object sender, EventArgs e)
        {
            First_Result.Text = string.Empty;
            Second_Result.Text = string.Empty;
            Third_Result.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}