using System.Diagnostics;

namespace BMICalculatorApp
{
    public partial class Form1 : Form
    {

        private BMICalculator BMICalculator
        {
            get; set;
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

        private void testSpeedBtn_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                var bmi = new BMICalculator(1.6f + i * 0.01f, 60 + i);
                bmi.CalculateBMI();
                var result = bmi.GetCategory(); 
            }
            sw.Stop();
            MessageBox.Show($"100 calculations took: {sw.ElapsedMilliseconds}ms");
        }
    }
}
