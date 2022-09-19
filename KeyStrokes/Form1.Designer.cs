namespace KeyStrokes
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
            this.TxtCounter = new System.Windows.Forms.TextBox();
            this.title1 = new System.Windows.Forms.Label();
            this.RichTxtBox = new System.Windows.Forms.RichTextBox();
            this.title2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCounter
            // 
            this.TxtCounter.Enabled = false;
            this.TxtCounter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCounter.Location = new System.Drawing.Point(236, 102);
            this.TxtCounter.Name = "TxtCounter";
            this.TxtCounter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtCounter.Size = new System.Drawing.Size(200, 39);
            this.TxtCounter.TabIndex = 0;
            this.TxtCounter.TextChanged += new System.EventHandler(this.TxtCounter_TextChanged);
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title1.Location = new System.Drawing.Point(54, 111);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(176, 25);
            this.title1.TabIndex = 1;
            this.title1.Text = "Times keys pressed:";
            // 
            // RichTxtBox
            // 
            this.RichTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTxtBox.Location = new System.Drawing.Point(236, 170);
            this.RichTxtBox.Name = "RichTxtBox";
            this.RichTxtBox.ReadOnly = true;
            this.RichTxtBox.Size = new System.Drawing.Size(400, 96);
            this.RichTxtBox.TabIndex = 2;
            this.RichTxtBox.Text = "";
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title2.Location = new System.Drawing.Point(12, 206);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(218, 25);
            this.title2.TabIndex = 3;
            this.title2.Text = "Pressed key information:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 311);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.RichTxtBox);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.TxtCounter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Count Keys...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtCounter;
        private Label title1;
        private RichTextBox RichTxtBox;
        private Label title2;
    }
}