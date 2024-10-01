namespace dropbox14
{
    partial class DisplayAllForm
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
            EmployeeListBox = new ListBox();
            label1 = new Label();
            closeButton = new Button();
            printButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.ItemHeight = 15;
            EmployeeListBox.Location = new Point(30, 34);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(591, 244);
            EmployeeListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "All Employees:";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(113, 293);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(120, 31);
            closeButton.TabIndex = 2;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            printButton.Location = new Point(434, 293);
            printButton.Name = "printButton";
            printButton.Size = new Size(120, 31);
            printButton.TabIndex = 3;
            printButton.Text = "&Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // DisplayAllForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(654, 336);
            Controls.Add(printButton);
            Controls.Add(closeButton);
            Controls.Add(label1);
            Controls.Add(EmployeeListBox);
            Name = "DisplayAllForm";
            Text = "DisplayAllForm";
            Load += DisplayAllForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EmployeeListBox;
        private Label label1;
        private Button closeButton;
        private Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}