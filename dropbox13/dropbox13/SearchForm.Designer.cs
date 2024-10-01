namespace dropbox13
{
    partial class SearchForm
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
            idLabel = new Label();
            label4 = new Label();
            nameLabel = new Label();
            label6 = new Label();
            gradeLabel = new Label();
            searchButton = new Button();
            closeButton = new Button();
            printButton = new Button();
            searchTextBox = new TextBox();
            groupBox1 = new GroupBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 46);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 85);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // idLabel
            // 
            idLabel.BorderStyle = BorderStyle.Fixed3D;
            idLabel.Location = new Point(418, 85);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(88, 38);
            idLabel.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 152);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 3;
            label4.Text = "Student Name:";
            // 
            // nameLabel
            // 
            nameLabel.BorderStyle = BorderStyle.Fixed3D;
            nameLabel.Location = new Point(418, 152);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(88, 38);
            nameLabel.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 216);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 5;
            label6.Text = "Letter Grade:";
            // 
            // gradeLabel
            // 
            gradeLabel.BorderStyle = BorderStyle.Fixed3D;
            gradeLabel.Location = new Point(418, 216);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(88, 38);
            gradeLabel.TabIndex = 6;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(616, 46);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 7;
            searchButton.Text = "&Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(187, 387);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 34);
            closeButton.TabIndex = 8;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(511, 387);
            printButton.Name = "printButton";
            printButton.Size = new Size(112, 34);
            printButton.TabIndex = 9;
            printButton.Text = "&Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(396, 46);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(150, 31);
            searchTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(idLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(gradeLabel);
            groupBox1.Location = new Point(93, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 280);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Students Found";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(searchTextBox);
            Controls.Add(printButton);
            Controls.Add(closeButton);
            Controls.Add(searchButton);
            Controls.Add(label1);
            Name = "SearchForm";
            Text = "SearchForm";
            Load += SearchForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label idLabel;
        private Label label4;
        private Label nameLabel;
        private Label label6;
        private Label gradeLabel;
        private Button searchButton;
        private Button closeButton;
        private Button printButton;
        private TextBox searchTextBox;
        private GroupBox groupBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}