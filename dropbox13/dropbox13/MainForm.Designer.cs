namespace dropbox13
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
            label1 = new Label();
            addButton = new Button();
            displayButton = new Button();
            searchButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 91);
            label1.Name = "label1";
            label1.Size = new Size(443, 63);
            label1.TabIndex = 0;
            label1.Text = "Sudent Records";
            // 
            // addButton
            // 
            addButton.Location = new Point(160, 242);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 1;
            addButton.Text = "&Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click_1;
            // 
            // displayButton
            // 
            displayButton.Location = new Point(491, 242);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(112, 34);
            displayButton.TabIndex = 2;
            displayButton.Text = "&Display";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(160, 361);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 3;
            searchButton.Text = "&Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(491, 361);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 4;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(searchButton);
            Controls.Add(displayButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addButton;
        private Button displayButton;
        private Button searchButton;
        private Button exitButton;
    }
}