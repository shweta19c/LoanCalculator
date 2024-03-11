namespace LoanCalculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_LoanAmount = new TextBox();
            txt_NumberOfMonths = new TextBox();
            txt_InterestRate = new TextBox();
            listBox1 = new ListBox();
            btn_Calculate = new Button();
            btn_Clear = new Button();
            btn_Exit = new Button();
            label4 = new Label();
            txt_FinalValue = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 60);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Loan Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 112);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Number of Months:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 164);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Interest Rate:";
            // 
            // txt_LoanAmount
            // 
            txt_LoanAmount.Location = new Point(307, 57);
            txt_LoanAmount.Name = "txt_LoanAmount";
            txt_LoanAmount.Size = new Size(125, 27);
            txt_LoanAmount.TabIndex = 3;
            // 
            // txt_NumberOfMonths
            // 
            txt_NumberOfMonths.Location = new Point(307, 105);
            txt_NumberOfMonths.Name = "txt_NumberOfMonths";
            txt_NumberOfMonths.Size = new Size(125, 27);
            txt_NumberOfMonths.TabIndex = 4;
            // 
            // txt_InterestRate
            // 
            txt_InterestRate.Location = new Point(307, 157);
            txt_InterestRate.Name = "txt_InterestRate";
            txt_InterestRate.Size = new Size(125, 27);
            txt_InterestRate.TabIndex = 5;
            txt_InterestRate.Text = "0.005";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(80, 225);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 204);
            listBox1.TabIndex = 6;
            // 
            // btn_Calculate
            // 
            btn_Calculate.Location = new Point(83, 512);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new Size(94, 29);
            btn_Calculate.TabIndex = 7;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = true;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(210, 512);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(94, 29);
            btn_Clear.TabIndex = 8;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(341, 512);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 9;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 457);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 10;
            label4.Text = "Final value:";
            // 
            // txt_FinalValue
            // 
            txt_FinalValue.Location = new Point(201, 454);
            txt_FinalValue.Name = "txt_FinalValue";
            txt_FinalValue.ReadOnly = true;
            txt_FinalValue.Size = new Size(125, 27);
            txt_FinalValue.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(txt_FinalValue);
            Controls.Add(label4);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Calculate);
            Controls.Add(listBox1);
            Controls.Add(txt_InterestRate);
            Controls.Add(txt_NumberOfMonths);
            Controls.Add(txt_LoanAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Loan Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_LoanAmount;
        private TextBox txt_NumberOfMonths;
        private TextBox txt_InterestRate;
        private ListBox listBox1;
        private Button btn_Calculate;
        private Button btn_Clear;
        private Button btn_Exit;
        private Label label4;
        private TextBox txt_FinalValue;
    }
}
