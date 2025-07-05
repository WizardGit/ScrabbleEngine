namespace ScrabbleEngine
{
    partial class MainForm
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
            this.LettersTextbox = new System.Windows.Forms.TextBox();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LettersTextbox
            // 
            this.LettersTextbox.Location = new System.Drawing.Point(23, 23);
            this.LettersTextbox.Name = "LettersTextbox";
            this.LettersTextbox.Size = new System.Drawing.Size(100, 20);
            this.LettersTextbox.TabIndex = 0;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(207, 23);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.ProcessBtn.TabIndex = 1;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(23, 66);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(120, 95);
            this.DisplayListBox.TabIndex = 2;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(207, 93);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 23);
            this.ProgressBar.TabIndex = 3;
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Location = new System.Drawing.Point(207, 66);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(48, 13);
            this.ProcessLabel.TabIndex = 4;
            this.ProcessLabel.Text = "Progress";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 219);
            this.Controls.Add(this.ProcessLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.LettersTextbox);
            this.Name = "MainForm";
            this.Text = "ScrabbleEngine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LettersTextbox;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProcessLabel;
    }
}

