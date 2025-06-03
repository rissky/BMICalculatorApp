namespace BMICalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                float height = float.Parse(txtHeight.Text);
                float weight = float.Parse(txtWeight.Text);

                float bmi = weight / (height * height);
                lblResult.Text = "BMI: " + bmi.ToString("0.00");

                // Categorise BMI
                if (bmi < 18.5)
                {
                    lblCategory.Text = "Underweight";
                }
                else if (bmi < 25)
                {
                    lblCategory.Text = "Healthy";
                }
                else if (bmi < 30)
                {
                    lblCategory.Text = "Overweight";
                }
                else
                {
                    lblCategory.Text = "Obese";
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for height and weight.");
            }

        }
    }
}
