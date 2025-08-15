namespace MS_Store_App
{
    partial class WindowName
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
            button1 = new Button();
            selectFolder = new FolderBrowserDialog();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(354, 34);
            button1.TabIndex = 0;
            button1.Text = "Select Folder to ZIP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // selectFolder
            // 
            selectFolder.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 11);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(354, 27);
            progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.MaximumSize = new Size(354, 100);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 2;
            label1.Text = "No folder selected to ZIP.";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(progressBar1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8);
            panel1.Size = new Size(378, 74);
            panel1.TabIndex = 3;
            // 
            // WindowName
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(378, 144);
            Controls.Add(panel1);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(400, 400);
            MinimumSize = new Size(400, 200);
            Name = "WindowName";
            ShowIcon = false;
            Text = "Folder Zipper";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private Label label1;
        private FolderBrowserDialog selectFolder;
        private Panel panel1;
    }
}
