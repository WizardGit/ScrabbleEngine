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
            this.SortLengthBtn = new System.Windows.Forms.Button();
            this.SortPointsBtn = new System.Windows.Forms.Button();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.CheckWordBtn = new System.Windows.Forms.Button();
            this.CheckWordTextBox = new System.Windows.Forms.TextBox();
            this.LineCheckMaskTextBox = new System.Windows.Forms.TextBox();
            this.LineCheckBtn = new System.Windows.Forms.Button();
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
            this.MaskTextBox.Location = new System.Drawing.Point(108, 23);
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(50, 20);
            this.MaskTextBox.TabIndex = 6;
            this.MaskTextBox.Text = "-------";
            // 
            // SortLengthBtn
            // 
            this.SortLengthBtn.Location = new System.Drawing.Point(216, 233);
            this.SortLengthBtn.Name = "SortLengthBtn";
            this.SortLengthBtn.Size = new System.Drawing.Size(108, 23);
            this.SortLengthBtn.TabIndex = 7;
            this.SortLengthBtn.Text = "Sort by Length";
            this.SortLengthBtn.UseVisualStyleBackColor = true;
            this.SortLengthBtn.Click += new System.EventHandler(this.SortLengthBtn_Click);
            // 
            // SortPointsBtn
            // 
            this.SortPointsBtn.Location = new System.Drawing.Point(216, 262);
            this.SortPointsBtn.Name = "SortPointsBtn";
            this.SortPointsBtn.Size = new System.Drawing.Size(108, 23);
            this.SortPointsBtn.TabIndex = 8;
            this.SortPointsBtn.Text = "Sort by Points";
            this.SortPointsBtn.UseVisualStyleBackColor = true;
            this.SortPointsBtn.Click += new System.EventHandler(this.SortPointsBtn_Click);
            // 
            // SortComboBox
            // 
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.SortComboBox.Location = new System.Drawing.Point(330, 235);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(121, 21);
            this.SortComboBox.TabIndex = 9;
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
            // 
            // CheckWordBtn
            // 
            this.CheckWordBtn.Location = new System.Drawing.Point(216, 291);
            this.CheckWordBtn.Name = "CheckWordBtn";
            this.CheckWordBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckWordBtn.TabIndex = 11;
            this.CheckWordBtn.Text = "Check Word";
            this.CheckWordBtn.UseVisualStyleBackColor = true;
            this.CheckWordBtn.Click += new System.EventHandler(this.CheckWordBtn_Click);
            // 
            // CheckWordTextBox
            // 
            this.CheckWordTextBox.Location = new System.Drawing.Point(297, 293);
            this.CheckWordTextBox.Name = "CheckWordTextBox";
            this.CheckWordTextBox.Size = new System.Drawing.Size(79, 20);
            this.CheckWordTextBox.TabIndex = 12;
            // 
            // LineCheckMaskTextBox
            // 
            this.LineCheckMaskTextBox.Location = new System.Drawing.Point(560, 61);
            this.LineCheckMaskTextBox.Name = "LineCheckMaskTextBox";
            this.LineCheckMaskTextBox.Size = new System.Drawing.Size(76, 20);
            this.LineCheckMaskTextBox.TabIndex = 14;
            this.LineCheckMaskTextBox.Text = "---------------";
            // 
            // LineCheckBtn
            // 
            this.LineCheckBtn.Location = new System.Drawing.Point(680, 58);
            this.LineCheckBtn.Name = "LineCheckBtn";
            this.LineCheckBtn.Size = new System.Drawing.Size(108, 39);
            this.LineCheckBtn.TabIndex = 13;
            this.LineCheckBtn.Text = "Check Line";
            this.LineCheckBtn.UseVisualStyleBackColor = true;
            this.LineCheckBtn.Click += new System.EventHandler(this.LineCheckBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 412);
            this.Controls.Add(this.LineCheckMaskTextBox);
            this.Controls.Add(this.LineCheckBtn);
            this.Controls.Add(this.CheckWordTextBox);
            this.Controls.Add(this.CheckWordBtn);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.SortPointsBtn);
            this.Controls.Add(this.SortLengthBtn);
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
        private System.Windows.Forms.Button SortLengthBtn;
        private System.Windows.Forms.Button SortPointsBtn;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.Button CheckWordBtn;
        private System.Windows.Forms.TextBox CheckWordTextBox;
        private System.Windows.Forms.TextBox LineCheckMaskTextBox;
        private System.Windows.Forms.Button LineCheckBtn;
    }
}

