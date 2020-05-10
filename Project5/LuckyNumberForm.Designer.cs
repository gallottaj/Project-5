namespace Project5
{
    partial class LuckyNumberForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.luckyNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(66, 136);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // luckyNumberLabel
            // 
            this.luckyNumberLabel.AutoSize = true;
            this.luckyNumberLabel.Location = new System.Drawing.Point(84, 94);
            this.luckyNumberLabel.Name = "luckyNumberLabel";
            this.luckyNumberLabel.Size = new System.Drawing.Size(46, 17);
            this.luckyNumberLabel.TabIndex = 2;
            this.luckyNumberLabel.Text = "label1";
            this.luckyNumberLabel.Click += new System.EventHandler(this.luckyNumberLabel_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Lucky Number!";
            // 
            // LuckyNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luckyNumberLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "LuckyNumberForm";
            this.Text = "Results!";
            this.Load += new System.EventHandler(this.LuckyNumberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label luckyNumberLabel;
        private System.Windows.Forms.Label label1;
    }
}