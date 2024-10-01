namespace dropbox14
{
    partial class AddHoursForm
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
            groupBox1 = new GroupBox();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            hoursTextBox = new TextBox();
            label3 = new Label();
            nameLabel = new Label();
            idLabel = new Label();
            closeandsaveButton = new Button();
            clearButton = new Button();
            nextButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(idTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(hoursTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(idLabel);
            groupBox1.Controls.Add(closeandsaveButton);
            groupBox1.Controls.Add(clearButton);
            groupBox1.Controls.Add(nextButton);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hours Data";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(383, 45);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(124, 23);
            idTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(383, 106);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(124, 23);
            nameTextBox.TabIndex = 7;
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(383, 165);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(124, 23);
            hoursTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(104, 165);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 5;
            label3.Text = "Hours Worked:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(104, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(140, 21);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Employee Name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.Location = new Point(104, 48);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(111, 21);
            idLabel.TabIndex = 3;
            idLabel.Text = "Employee ID:";
            // 
            // closeandsaveButton
            // 
            closeandsaveButton.Location = new Point(453, 228);
            closeandsaveButton.Name = "closeandsaveButton";
            closeandsaveButton.Size = new Size(90, 42);
            closeandsaveButton.TabIndex = 2;
            closeandsaveButton.Text = "&Close and &Save";
            closeandsaveButton.UseVisualStyleBackColor = true;
            closeandsaveButton.Click += closeandsaveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(266, 228);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(96, 42);
            clearButton.TabIndex = 1;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(77, 228);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(90, 42);
            nextButton.TabIndex = 0;
            nextButton.Text = "&Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // AddHoursForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(661, 322);
            Controls.Add(groupBox1);
            Name = "AddHoursForm";
            Text = "AddHoursForm";
            Load += AddHoursForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox hoursTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button closeandsaveButton;
        private Button clearButton;
        private Button nextButton;
        private Label nameLabel;
        private Label idLabel;
    }
}