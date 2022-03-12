namespace Element_PPT_Helper
{
    partial class PPTControlForm
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
            this.SwitchToPointerButton = new System.Windows.Forms.Button();
            this.SwitchToPenButton = new System.Windows.Forms.Button();
            this.SwitchToEraserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SwitchToPointerButton
            // 
            this.SwitchToPointerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchToPointerButton.Location = new System.Drawing.Point(0, 0);
            this.SwitchToPointerButton.Name = "SwitchToPointerButton";
            this.SwitchToPointerButton.Size = new System.Drawing.Size(36, 36);
            this.SwitchToPointerButton.TabIndex = 0;
            this.SwitchToPointerButton.Text = "Pointer";
            this.SwitchToPointerButton.UseVisualStyleBackColor = false;
            this.SwitchToPointerButton.Click += new System.EventHandler(this.SwitchToPointerButton_Click);
            // 
            // SwitchToPenButton
            // 
            this.SwitchToPenButton.BackColor = System.Drawing.Color.Transparent;
            this.SwitchToPenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchToPenButton.Location = new System.Drawing.Point(36, 0);
            this.SwitchToPenButton.Name = "SwitchToPenButton";
            this.SwitchToPenButton.Size = new System.Drawing.Size(36, 36);
            this.SwitchToPenButton.TabIndex = 1;
            this.SwitchToPenButton.Text = "Pen";
            this.SwitchToPenButton.UseVisualStyleBackColor = false;
            this.SwitchToPenButton.Click += new System.EventHandler(this.SwitchToPenButton_Click);
            // 
            // SwitchToEraserButton
            // 
            this.SwitchToEraserButton.BackColor = System.Drawing.Color.Transparent;
            this.SwitchToEraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchToEraserButton.Location = new System.Drawing.Point(72, 0);
            this.SwitchToEraserButton.Name = "SwitchToEraserButton";
            this.SwitchToEraserButton.Size = new System.Drawing.Size(36, 36);
            this.SwitchToEraserButton.TabIndex = 2;
            this.SwitchToEraserButton.Text = "Eraser";
            this.SwitchToEraserButton.UseVisualStyleBackColor = false;
            this.SwitchToEraserButton.Click += new System.EventHandler(this.SwitchToEraserButton_Click);
            // 
            // PPTControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 36);
            this.Controls.Add(this.SwitchToEraserButton);
            this.Controls.Add(this.SwitchToPenButton);
            this.Controls.Add(this.SwitchToPointerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PPTControlForm";
            this.Text = "PPT Control Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PPTControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SwitchToPointerButton;
        private System.Windows.Forms.Button SwitchToPenButton;
        private System.Windows.Forms.Button SwitchToEraserButton;
    }
}