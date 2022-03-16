namespace WaveToMp3Demo
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
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.SetOutputButton = new System.Windows.Forms.Button();
            this.InputFileTextBox = new System.Windows.Forms.TextBox();
            this.OutputFileTextBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(26, 106);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(143, 49);
            this.ChooseFileButton.TabIndex = 0;
            this.ChooseFileButton.Text = "Choose File";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // SetOutputButton
            // 
            this.SetOutputButton.Location = new System.Drawing.Point(26, 199);
            this.SetOutputButton.Name = "SetOutputButton";
            this.SetOutputButton.Size = new System.Drawing.Size(143, 49);
            this.SetOutputButton.TabIndex = 1;
            this.SetOutputButton.Text = "Set Output";
            this.SetOutputButton.UseVisualStyleBackColor = true;
            this.SetOutputButton.Click += new System.EventHandler(this.SetOutputButton_Click);
            // 
            // InputFileTextBox
            // 
            this.InputFileTextBox.Location = new System.Drawing.Point(193, 106);
            this.InputFileTextBox.Multiline = true;
            this.InputFileTextBox.Name = "InputFileTextBox";
            this.InputFileTextBox.Size = new System.Drawing.Size(578, 49);
            this.InputFileTextBox.TabIndex = 2;
            // 
            // OutputFileTextBox
            // 
            this.OutputFileTextBox.Location = new System.Drawing.Point(193, 199);
            this.OutputFileTextBox.Multiline = true;
            this.OutputFileTextBox.Name = "OutputFileTextBox";
            this.OutputFileTextBox.Size = new System.Drawing.Size(578, 49);
            this.OutputFileTextBox.TabIndex = 3;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(599, 287);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(172, 60);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert to MP3";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OutputFileTextBox);
            this.Controls.Add(this.InputFileTextBox);
            this.Controls.Add(this.SetOutputButton);
            this.Controls.Add(this.ChooseFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChooseFileButton;
        private Button SetOutputButton;
        private TextBox InputFileTextBox;
        private TextBox OutputFileTextBox;
        private Button ConvertButton;
    }
}