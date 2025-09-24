namespace BasicThreading
{
    partial class Form1
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
            this.Threading = new System.Windows.Forms.Label();
            this.StartThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Threading
            // 
            this.Threading.AutoSize = true;
            this.Threading.Font = new System.Drawing.Font("Niagara Engraved", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threading.Location = new System.Drawing.Point(79, 78);
            this.Threading.Name = "Threading";
            this.Threading.Size = new System.Drawing.Size(226, 36);
            this.Threading.TabIndex = 0;
            this.Threading.Text = "-Before starting thread-";
            // 
            // StartThread
            // 
            this.StartThread.Font = new System.Drawing.Font("Niagara Engraved", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartThread.Location = new System.Drawing.Point(113, 186);
            this.StartThread.Name = "StartThread";
            this.StartThread.Size = new System.Drawing.Size(142, 38);
            this.StartThread.TabIndex = 1;
            this.StartThread.Text = "RUN";
            this.StartThread.UseVisualStyleBackColor = true;
            this.StartThread.Click += new System.EventHandler(this.StartThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(385, 323);
            this.Controls.Add(this.StartThread);
            this.Controls.Add(this.Threading);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Threading;
        private System.Windows.Forms.Button StartThread;
    }
}

