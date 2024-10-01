namespace dropbox13
{
    partial class DisplayForm
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
            label1 = new Label();
            label2 = new Label();
            studentsListBox = new ListBox();
            closeeButton = new Button();
            printButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "All Students:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 107);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // studentsListBox
            // 
            studentsListBox.FormattingEnabled = true;
            studentsListBox.ItemHeight = 25;
            studentsListBox.Location = new Point(12, 46);
            studentsListBox.Name = "studentsListBox";
            studentsListBox.Size = new Size(776, 329);
            studentsListBox.TabIndex = 2;
            // 
            // closeeButton
            // 
            closeeButton.Location = new Point(181, 381);
            closeeButton.Name = "closeeButton";
            closeeButton.Size = new Size(112, 34);
            closeeButton.TabIndex = 3;
            closeeButton.Text = "Cl&ose";
            closeeButton.UseVisualStyleBackColor = true;
            closeeButton.Click += closeeButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(464, 381);
            printButton.Name = "printButton";
            printButton.Size = new Size(112, 34);
            printButton.TabIndex = 4;
            printButton.Text = "&print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(printButton);
            Controls.Add(closeeButton);
            Controls.Add(studentsListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DisplayForm";
            Text = "DisplayForm";
            Load += DisplayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox studentsListBox;
        private Button closeeButton;
        private Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}