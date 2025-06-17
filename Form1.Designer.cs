namespace BMICalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            lblCategory = new Label();
            lblResult = new Label();
            testSpeedBtn = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(223, 136);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(143, 34);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate BMI";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 65);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "Height (m)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 102);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 2;
            label2.Text = "Weight (kg)";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(223, 62);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(150, 31);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(223, 99);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(150, 31);
            txtWeight.TabIndex = 4;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(114, 292);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(0, 25);
            lblCategory.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(121, 255);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 5;
            // 
            // testSpeedBtn
            // 
            testSpeedBtn.Location = new Point(111, 346);
            testSpeedBtn.Name = "testSpeedBtn";
            testSpeedBtn.Size = new Size(112, 34);
            testSpeedBtn.TabIndex = 7;
            testSpeedBtn.Text = "Test Speed";
            testSpeedBtn.UseVisualStyleBackColor = true;
            testSpeedBtn.Click += testSpeedBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testSpeedBtn);
            Controls.Add(lblCategory);
            Controls.Add(lblResult);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label lblCategory;
        private Label lblResult;
        private Button testSpeedBtn;
    }
}
