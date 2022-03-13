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
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SwitchToPointerButton
            // 
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
            this.SwitchToEraserButton.Location = new System.Drawing.Point(72, 0);
            this.SwitchToEraserButton.Name = "SwitchToEraserButton";
            this.SwitchToEraserButton.Size = new System.Drawing.Size(36, 36);
            this.SwitchToEraserButton.TabIndex = 2;
            this.SwitchToEraserButton.Text = "Eraser";
            this.SwitchToEraserButton.UseVisualStyleBackColor = false;
            this.SwitchToEraserButton.Click += new System.EventHandler(this.SwitchToEraserButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.Location = new System.Drawing.Point(324, 0);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(36, 36);
            this.NextPageButton.TabIndex = 2;
            this.NextPageButton.Text = "Next";
            this.NextPageButton.UseVisualStyleBackColor = false;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.Location = new System.Drawing.Point(288, 0);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(36, 36);
            this.PreviousPageButton.TabIndex = 2;
            this.PreviousPageButton.Text = "Prev";
            this.PreviousPageButton.UseVisualStyleBackColor = false;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(108, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(36, 36);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PPTControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 36);
            this.Controls.Add(this.PreviousPageButton);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SwitchToEraserButton);
            this.Controls.Add(this.SwitchToPenButton);
            this.Controls.Add(this.SwitchToPointerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PPTControlForm";
            this.Opacity = 0.75D;
            this.Text = "PPT Control Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PPTControlForm_Load);
            this.VisibleChanged += new System.EventHandler(this.PPTControlForm_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SwitchToPointerButton;
        private System.Windows.Forms.Button SwitchToPenButton;
        private System.Windows.Forms.Button SwitchToEraserButton;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.Button ExitButton;
    }
}