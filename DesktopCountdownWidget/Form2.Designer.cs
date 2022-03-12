namespace DesktopCountdownWidget
{
    partial class ConfigForm
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
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.TextColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextColorButton
            // 
            this.TextColorButton.Location = new System.Drawing.Point(12, 12);
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new System.Drawing.Size(75, 23);
            this.TextColorButton.TabIndex = 0;
            this.TextColorButton.Text = "Text color";
            this.TextColorButton.UseVisualStyleBackColor = true;
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.TextColorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.Text = "Config - DesktopCountdownWidget";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Button TextColorButton;
    }
}