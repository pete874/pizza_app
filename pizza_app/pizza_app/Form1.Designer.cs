namespace pizza_app
{
    partial class PizzaForm
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
            this.TuotteetPN = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TuotteetBT = new System.Windows.Forms.Button();
            this.VahvistaBT = new System.Windows.Forms.Button();
            this.MaksaBT = new System.Windows.Forms.Button();
            this.HeaderLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TuotteetPN
            // 
            this.TuotteetPN.Location = new System.Drawing.Point(0, 76);
            this.TuotteetPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TuotteetPN.Name = "TuotteetPN";
            this.TuotteetPN.Size = new System.Drawing.Size(1106, 588);
            this.TuotteetPN.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.HeaderLB);
            this.panel1.Controls.Add(this.VahvistaBT);
            this.panel1.Controls.Add(this.MaksaBT);
            this.panel1.Controls.Add(this.TuotteetBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 68);
            this.panel1.TabIndex = 1;
            // 
            // TuotteetBT
            // 
            this.TuotteetBT.Location = new System.Drawing.Point(226, 36);
            this.TuotteetBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TuotteetBT.Name = "TuotteetBT";
            this.TuotteetBT.Size = new System.Drawing.Size(120, 28);
            this.TuotteetBT.TabIndex = 0;
            this.TuotteetBT.Text = "Tuotteet";
            this.TuotteetBT.UseVisualStyleBackColor = true;
            // 
            // VahvistaBT
            // 
            this.VahvistaBT.Location = new System.Drawing.Point(512, 36);
            this.VahvistaBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VahvistaBT.Name = "VahvistaBT";
            this.VahvistaBT.Size = new System.Drawing.Size(117, 28);
            this.VahvistaBT.TabIndex = 1;
            this.VahvistaBT.Text = "Vahvista tilaus";
            this.VahvistaBT.UseVisualStyleBackColor = true;
            // 
            // MaksaBT
            // 
            this.MaksaBT.Location = new System.Drawing.Point(783, 36);
            this.MaksaBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaksaBT.Name = "MaksaBT";
            this.MaksaBT.Size = new System.Drawing.Size(109, 28);
            this.MaksaBT.TabIndex = 2;
            this.MaksaBT.Text = "Maksa tilaus";
            this.MaksaBT.UseVisualStyleBackColor = true;
            // 
            // HeaderLB
            // 
            this.HeaderLB.AutoSize = true;
            this.HeaderLB.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLB.ForeColor = System.Drawing.Color.PaleGreen;
            this.HeaderLB.Location = new System.Drawing.Point(13, 22);
            this.HeaderLB.Name = "HeaderLB";
            this.HeaderLB.Size = new System.Drawing.Size(92, 23);
            this.HeaderLB.TabIndex = 3;
            this.HeaderLB.Text = "Pizza App";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TuotteetPN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PizzaForm";
            this.Text = "Pizza App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TuotteetPN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderLB;
        private System.Windows.Forms.Button VahvistaBT;
        private System.Windows.Forms.Button MaksaBT;
        private System.Windows.Forms.Button TuotteetBT;
    }
}

