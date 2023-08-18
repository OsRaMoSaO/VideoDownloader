namespace VideoDownloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            linkBox = new TextBox();
            downloadBtn = new Button();
            label1 = new Label();
            folderD = new FolderBrowserDialog();
            button1 = new Button();
            label2 = new Label();
            pathText = new TextBox();
            outText = new Label();
            SuspendLayout();
            // 
            // linkBox
            // 
            linkBox.Location = new Point(12, 29);
            linkBox.Name = "linkBox";
            linkBox.Size = new Size(405, 23);
            linkBox.TabIndex = 0;
            // 
            // downloadBtn
            // 
            downloadBtn.Location = new Point(434, 28);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(75, 23);
            downloadBtn.TabIndex = 1;
            downloadBtn.Text = "Download!";
            downloadBtn.UseVisualStyleBackColor = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Youtube link:";
            // 
            // button1
            // 
            button1.Location = new Point(434, 121);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Select!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Output folder:";
            // 
            // pathText
            // 
            pathText.Location = new Point(12, 121);
            pathText.Name = "pathText";
            pathText.Size = new Size(405, 23);
            pathText.TabIndex = 5;
            // 
            // outText
            // 
            outText.AutoSize = true;
            outText.Location = new Point(12, 55);
            outText.Name = "outText";
            outText.Size = new Size(0, 15);
            outText.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 156);
            Controls.Add(outText);
            Controls.Add(pathText);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(downloadBtn);
            Controls.Add(linkBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YtDowloader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox linkBox;
        private Button downloadBtn;
        private Label label1;
        private FolderBrowserDialog folderD;
        private Button button1;
        private Label label2;
        private TextBox pathText;
        private Label outText;
    }
}