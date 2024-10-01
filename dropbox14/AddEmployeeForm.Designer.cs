namespace dropbox14
{
    partial class AddEmployeeForm : Form
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
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            payrateTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            saveButton = new Button();
            clearButton = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(445, 71);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(128, 23);
            idTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(445, 154);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(128, 23);
            nameTextBox.TabIndex = 2;
            // 
            // payrateTextBox
            // 
            payrateTextBox.Location = new Point(445, 241);
            payrateTextBox.Name = "payrateTextBox";
            payrateTextBox.Size = new Size(128, 23);
            payrateTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(174, 71);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 4;
            label1.Text = "Employee ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(174, 154);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 5;
            label2.Text = "Employee Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(174, 241);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 6;
            label3.Text = "Pay Rate:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(clearButton);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(payrateTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(idTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(719, 345);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Employee";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(102, 292);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(115, 35);
            saveButton.TabIndex = 8;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(316, 293);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(115, 33);
            clearButton.TabIndex = 9;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(527, 291);
            button3.Name = "button3";
            button3.Size = new Size(115, 35);
            button3.TabIndex = 10;
            button3.Text = "&Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(743, 369);
            Controls.Add(groupBox1);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox payrateTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button saveButton;
        private Button clearButton;
        private Button button3;
    }
}