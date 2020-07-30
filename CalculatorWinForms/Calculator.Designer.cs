namespace CalculatorWinForms
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculatorTextBox = new System.Windows.Forms.TextBox();
            this.CalculatorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CEbutton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.Plusbutton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorTextBox
            // 
            this.CalculatorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatorTextBox.Location = new System.Drawing.Point(20, 20);
            this.CalculatorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalculatorTextBox.Name = "CalculatorTextBox";
            this.CalculatorTextBox.Size = new System.Drawing.Size(440, 26);
            this.CalculatorTextBox.TabIndex = 0;
            this.CalculatorTextBox.TextChanged += new System.EventHandler(this.CalculatorTextBox_TextChanged);
            // 
            // CalculatorLabel
            // 
            this.CalculatorLabel.AutoSize = true;
            this.CalculatorLabel.Location = new System.Drawing.Point(39, 62);
            this.CalculatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CalculatorLabel.Name = "CalculatorLabel";
            this.CalculatorLabel.Size = new System.Drawing.Size(0, 20);
            this.CalculatorLabel.TabIndex = 1;
            this.CalculatorLabel.Click += new System.EventHandler(this.CalculatorLabelText_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.EqualsButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button18, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ZeroButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Plusbutton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ThreeButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TwoButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.OneButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SubtractButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.SixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.FiveButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FourButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MultiplyButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.NineButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.EightButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SevenButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DivisionButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.DelButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cbutton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CEbutton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 368);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CEbutton
            // 
            this.CEbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(105, 67);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CeButtonClick);
            // 
            // Cbutton
            // 
            this.Cbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbutton.Location = new System.Drawing.Point(114, 3);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(105, 67);
            this.Cbutton.TabIndex = 1;
            this.Cbutton.Text = "C";
            this.Cbutton.UseVisualStyleBackColor = true;
            this.Cbutton.Click += new System.EventHandler(this.CbuttonClick);
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(225, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(105, 67);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "DEL";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButtonClick);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivisionButton.Location = new System.Drawing.Point(336, 3);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(108, 67);
            this.DivisionButton.TabIndex = 3;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivideButtonClick);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 76);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(105, 67);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButtonClick);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(114, 76);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(105, 67);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButtonClick);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Location = new System.Drawing.Point(225, 76);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(105, 67);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButtonClick);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.Location = new System.Drawing.Point(336, 76);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(108, 67);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButtonClick);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 149);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(105, 67);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButtonClick);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(114, 149);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(105, 67);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButtonClick);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(225, 149);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(105, 67);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButtonClick);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtractButton.Location = new System.Drawing.Point(336, 149);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(108, 67);
            this.SubtractButton.TabIndex = 11;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.MinusButtonClick);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 222);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(105, 67);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(114, 222);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(105, 67);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(225, 222);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(105, 67);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButtonClick);
            // 
            // Plusbutton
            // 
            this.Plusbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plusbutton.Location = new System.Drawing.Point(336, 222);
            this.Plusbutton.Name = "Plusbutton";
            this.Plusbutton.Size = new System.Drawing.Size(108, 67);
            this.Plusbutton.TabIndex = 15;
            this.Plusbutton.Text = "+";
            this.Plusbutton.UseVisualStyleBackColor = true;
            this.Plusbutton.Click += new System.EventHandler(this.PlusButtonClick);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(114, 295);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(105, 70);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButtonClick);
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Location = new System.Drawing.Point(225, 295);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(105, 70);
            this.button18.TabIndex = 18;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Location = new System.Drawing.Point(336, 295);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(108, 70);
            this.EqualsButton.TabIndex = 19;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButtonClick);
            // 
            // Calculator
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEbutton;
            this.ClientSize = new System.Drawing.Size(480, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CalculatorLabel);
            this.Controls.Add(this.CalculatorTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalculatorTextBox;
        private System.Windows.Forms.Label CalculatorLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button Plusbutton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button CEbutton;
    }
}

