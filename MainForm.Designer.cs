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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.MaskTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LettersTextbox
            // 
            this.LettersTextbox.Location = new System.Drawing.Point(23, 23);
            this.LettersTextbox.Name = "LettersTextbox";
            this.LettersTextbox.Size = new System.Drawing.Size(79, 20);
            this.LettersTextbox.TabIndex = 0;
            this.LettersTextbox.Text = "abcdefg";
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(228, 20);
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
            this.DisplayListBox.Size = new System.Drawing.Size(187, 277);
            this.DisplayListBox.TabIndex = 2;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(228, 90);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(212, 23);
            this.ProgressBar.TabIndex = 3;
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Location = new System.Drawing.Point(228, 63);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(48, 13);
            this.ProcessLabel.TabIndex = 4;
            this.ProcessLabel.Text = "Progress";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(240, 175);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(113, 13);
            this.InstructionLabel.TabIndex = 5;
            this.InstructionLabel.Text = "use * as wildcard letter";
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Location = new System.Drawing.Point(131, 22);
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(79, 20);
            this.MaskTextBox.TabIndex = 6;
            this.MaskTextBox.Text = "-------";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 359);
            this.Controls.Add(this.MaskTextBox);
            this.Controls.Add(this.InstructionLabel);
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
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TextBox MaskTextBox;
    }
}

