namespace dropbox14
{
    partial class MainForm
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
            addButton = new Button();
            hoursButton = new Button();
            displayButton = new Button();
            exitButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(143, 173);
            addButton.Name = "addButton";
            addButton.Size = new Size(91, 40);
            addButton.TabIndex = 0;
            addButton.Text = "&Add Employee";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // hoursButton
            // 
            hoursButton.Location = new Point(462, 173);
            hoursButton.Name = "hoursButton";
            hoursButton.Size = new Size(91, 40);
            hoursButton.TabIndex = 1;
            hoursButton.Text = "&Add Hours Worked";
            hoursButton.UseVisualStyleBackColor = true;
            hoursButton.Click += hoursButton_Click;
            // 
            // displayButton
            // 
            displayButton.Location = new Point(143, 296);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(91, 33);
            displayButton.TabIndex = 2;
            displayButton.Text = "&Display All";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(462, 296);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(91, 33);
            exitButton.TabIndex = 3;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Font = new Font("Lucida Console", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(121, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(448, 39);
            textBox1.TabIndex = 4;
            textBox1.Text = "Employee Payroll System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(689, 385);
            Controls.Add(textBox1);
            Controls.Add(exitButton);
            Controls.Add(displayButton);
            Controls.Add(hoursButton);
            Controls.Add(addButton);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button hoursButton;
        private Button displayButton;
        private Button exitButton;
        private TextBox textBox1;
    }
}