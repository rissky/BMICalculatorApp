namespace BMICalculatorApp
{
    public partial class Form1 : Form
    {

        private BMICalculator BMICalculator
        {
            get;set;
        }
        public Form1()
        {
            InitializeComponent();
            BMICalculator = new BMICalculator();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                float height = float.Parse(txtHeight.Text);
                float weight = float.Parse(txtWeight.Text);
                BMICalculator.Weight = weight;
                BMICalculator.Height = height;

                float bmi = BMICalculator.CalculateBMI();
                BMIType bMIType = BMICalculator.GetCategory();

                lblResult.Text = "BMI: " + bmi.ToString("0.00");
                lblCategory.Text = Enum.GetName(bMIType.GetType(), bMIType);
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for height and weight.");
            }

        }
    }
}
