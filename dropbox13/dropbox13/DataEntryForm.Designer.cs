namespace dropbox13
{
    partial class DataEntryForm
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
            scoreTextBox = new TextBox();
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            closeButton = new Button();
            clearButton = new Button();
            saveButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(scoreTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(idTextBox);
            groupBox1.Controls.Add(closeButton);
            groupBox1.Controls.Add(clearButton);
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 449);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Data";
            // 
            // scoreTextBox
            // 
            scoreTextBox.Location = new Point(558, 338);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.Size = new Size(150, 31);
            scoreTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(558, 225);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(143, 31);
            nameTextBox.TabIndex = 7;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(558, 126);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(150, 31);
            idTextBox.TabIndex = 6;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(558, 404);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 34);
            closeButton.TabIndex = 5;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(348, 404);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 4;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(134, 404);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 3;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 338);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 2;
            label3.Text = "Student Score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 225);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 1;
            label2.Text = "Student Name:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 126);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // DataEntryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "DataEntryForm";
            Text = "Data Entry Form";
            Load += DataEntryForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button closeButton;
        private Button clearButton;
        private Button saveButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private TextBox scoreTextBox;
    }
}