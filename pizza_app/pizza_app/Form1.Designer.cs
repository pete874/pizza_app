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
            this.HeaderPN = new System.Windows.Forms.Panel();
            this.TuotteetBT = new System.Windows.Forms.Button();
            this.HeaderLB = new System.Windows.Forms.Label();
            this.OstoskoriBT = new System.Windows.Forms.Button();
            this.MaksaBT = new System.Windows.Forms.Button();
            this.TuotteetPN = new System.Windows.Forms.SplitContainer();
            this.LisaaPizzaBT = new System.Windows.Forms.Button();
            this.PizzaCB = new System.Windows.Forms.ComboBox();
            this.LisaaTayteBT = new System.Windows.Forms.Button();
            this.TayteCB = new System.Windows.Forms.ComboBox();
            this.FooterPN = new System.Windows.Forms.Panel();
            this.VahvistukseenBT = new System.Windows.Forms.Button();
            this.SummaLB = new System.Windows.Forms.Label();
            this.SummaTitleLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.HeaderPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TuotteetPN)).BeginInit();
            this.TuotteetPN.Panel1.SuspendLayout();
            this.TuotteetPN.Panel2.SuspendLayout();
            this.TuotteetPN.SuspendLayout();
            this.FooterPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPN
            // 
            this.HeaderPN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeaderPN.Controls.Add(this.TuotteetBT);
            this.HeaderPN.Controls.Add(this.HeaderLB);
            this.HeaderPN.Controls.Add(this.OstoskoriBT);
            this.HeaderPN.Controls.Add(this.MaksaBT);
            this.HeaderPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeaderPN.Location = new System.Drawing.Point(0, 0);
            this.HeaderPN.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPN.Name = "HeaderPN";
            this.HeaderPN.Size = new System.Drawing.Size(1106, 77);
            this.HeaderPN.TabIndex = 1;
            // 
            // TuotteetBT
            // 
            this.TuotteetBT.BackColor = System.Drawing.Color.Beige;
            this.TuotteetBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TuotteetBT.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuotteetBT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TuotteetBT.Location = new System.Drawing.Point(242, 36);
            this.TuotteetBT.Margin = new System.Windows.Forms.Padding(4);
            this.TuotteetBT.Name = "TuotteetBT";
            this.TuotteetBT.Size = new System.Drawing.Size(147, 28);
            this.TuotteetBT.TabIndex = 0;
            this.TuotteetBT.Text = "Tuotteet";
            this.TuotteetBT.UseVisualStyleBackColor = false;
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
            // OstoskoriBT
            // 
            this.OstoskoriBT.BackColor = System.Drawing.Color.Beige;
            this.OstoskoriBT.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OstoskoriBT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.OstoskoriBT.Location = new System.Drawing.Point(512, 36);
            this.OstoskoriBT.Margin = new System.Windows.Forms.Padding(4);
            this.OstoskoriBT.Name = "OstoskoriBT";
            this.OstoskoriBT.Size = new System.Drawing.Size(146, 28);
            this.OstoskoriBT.TabIndex = 1;
            this.OstoskoriBT.Text = "Ostoskori";
            this.OstoskoriBT.UseVisualStyleBackColor = false;
            // 
            // MaksaBT
            // 
            this.MaksaBT.BackColor = System.Drawing.Color.Beige;
            this.MaksaBT.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaksaBT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MaksaBT.Location = new System.Drawing.Point(783, 36);
            this.MaksaBT.Margin = new System.Windows.Forms.Padding(4);
            this.MaksaBT.Name = "MaksaBT";
            this.MaksaBT.Size = new System.Drawing.Size(139, 28);
            this.MaksaBT.TabIndex = 2;
            this.MaksaBT.Text = "Maksa tilaus";
            this.MaksaBT.UseVisualStyleBackColor = false;
            // 
            // TuotteetPN
            // 
            this.TuotteetPN.Location = new System.Drawing.Point(0, 71);
            this.TuotteetPN.Name = "TuotteetPN";
            // 
            // TuotteetPN.Panel1
            // 
            this.TuotteetPN.Panel1.BackColor = System.Drawing.Color.Beige;
            this.TuotteetPN.Panel1.Controls.Add(this.label6);
            this.TuotteetPN.Panel1.Controls.Add(this.label7);
            this.TuotteetPN.Panel1.Controls.Add(this.label8);
            this.TuotteetPN.Panel1.Controls.Add(this.label9);
            this.TuotteetPN.Panel1.Controls.Add(this.label10);
            this.TuotteetPN.Panel1.Controls.Add(this.label5);
            this.TuotteetPN.Panel1.Controls.Add(this.label4);
            this.TuotteetPN.Panel1.Controls.Add(this.label3);
            this.TuotteetPN.Panel1.Controls.Add(this.label2);
            this.TuotteetPN.Panel1.Controls.Add(this.label1);
            this.TuotteetPN.Panel1.Controls.Add(this.LisaaPizzaBT);
            this.TuotteetPN.Panel1.Controls.Add(this.PizzaCB);
            // 
            // TuotteetPN.Panel2
            // 
            this.TuotteetPN.Panel2.BackColor = System.Drawing.Color.Beige;
            this.TuotteetPN.Panel2.Controls.Add(this.LisaaTayteBT);
            this.TuotteetPN.Panel2.Controls.Add(this.TayteCB);
            this.TuotteetPN.Size = new System.Drawing.Size(1106, 510);
            this.TuotteetPN.SplitterDistance = 638;
            this.TuotteetPN.TabIndex = 2;
            // 
            // LisaaPizzaBT
            // 
            this.LisaaPizzaBT.Location = new System.Drawing.Point(350, 89);
            this.LisaaPizzaBT.Name = "LisaaPizzaBT";
            this.LisaaPizzaBT.Size = new System.Drawing.Size(77, 23);
            this.LisaaPizzaBT.TabIndex = 1;
            this.LisaaPizzaBT.Text = "Lisää";
            this.LisaaPizzaBT.UseVisualStyleBackColor = true;
            // 
            // PizzaCB
            // 
            this.PizzaCB.FormattingEnabled = true;
            this.PizzaCB.Location = new System.Drawing.Point(200, 88);
            this.PizzaCB.Name = "PizzaCB";
            this.PizzaCB.Size = new System.Drawing.Size(144, 24);
            this.PizzaCB.TabIndex = 0;
            this.PizzaCB.Text = "Valitse pizza...";
            // 
            // LisaaTayteBT
            // 
            this.LisaaTayteBT.Location = new System.Drawing.Point(261, 89);
            this.LisaaTayteBT.Name = "LisaaTayteBT";
            this.LisaaTayteBT.Size = new System.Drawing.Size(75, 23);
            this.LisaaTayteBT.TabIndex = 2;
            this.LisaaTayteBT.Text = "Lisää";
            this.LisaaTayteBT.UseVisualStyleBackColor = true;
            this.LisaaTayteBT.Visible = false;
            // 
            // TayteCB
            // 
            this.TayteCB.FormattingEnabled = true;
            this.TayteCB.Location = new System.Drawing.Point(111, 89);
            this.TayteCB.Name = "TayteCB";
            this.TayteCB.Size = new System.Drawing.Size(144, 24);
            this.TayteCB.TabIndex = 1;
            this.TayteCB.Text = "Valitse täyte...";
            this.TayteCB.Visible = false;
            // 
            // FooterPN
            // 
            this.FooterPN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FooterPN.Controls.Add(this.VahvistukseenBT);
            this.FooterPN.Controls.Add(this.SummaLB);
            this.FooterPN.Controls.Add(this.SummaTitleLB);
            this.FooterPN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPN.Location = new System.Drawing.Point(0, 579);
            this.FooterPN.Name = "FooterPN";
            this.FooterPN.Size = new System.Drawing.Size(1106, 85);
            this.FooterPN.TabIndex = 3;
            // 
            // VahvistukseenBT
            // 
            this.VahvistukseenBT.Location = new System.Drawing.Point(995, 25);
            this.VahvistukseenBT.Name = "VahvistukseenBT";
            this.VahvistukseenBT.Size = new System.Drawing.Size(86, 42);
            this.VahvistukseenBT.TabIndex = 2;
            this.VahvistukseenBT.Text = "Vahvista";
            this.VahvistukseenBT.UseVisualStyleBackColor = true;
            // 
            // SummaLB
            // 
            this.SummaLB.AutoSize = true;
            this.SummaLB.BackColor = System.Drawing.SystemColors.Control;
            this.SummaLB.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaLB.Location = new System.Drawing.Point(270, 32);
            this.SummaLB.Name = "SummaLB";
            this.SummaLB.Size = new System.Drawing.Size(92, 23);
            this.SummaLB.TabIndex = 1;
            this.SummaLB.Text = "Summa €";
            // 
            // SummaTitleLB
            // 
            this.SummaTitleLB.AutoSize = true;
            this.SummaTitleLB.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaTitleLB.ForeColor = System.Drawing.SystemColors.Control;
            this.SummaTitleLB.Location = new System.Drawing.Point(69, 30);
            this.SummaTitleLB.Name = "SummaTitleLB";
            this.SummaTitleLB.Size = new System.Drawing.Size(195, 25);
            this.SummaTitleLB.TabIndex = 0;
            this.SummaTitleLB.Text = "Ostoskorin summa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Americana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Margarita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mexicana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quattro Stagioni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oma valinta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "11€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "10€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "10€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "10€";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "8€";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 664);
            this.Controls.Add(this.FooterPN);
            this.Controls.Add(this.HeaderPN);
            this.Controls.Add(this.TuotteetPN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PizzaForm";
            this.Text = "Pizza App";
            this.HeaderPN.ResumeLayout(false);
            this.HeaderPN.PerformLayout();
            this.TuotteetPN.Panel1.ResumeLayout(false);
            this.TuotteetPN.Panel1.PerformLayout();
            this.TuotteetPN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TuotteetPN)).EndInit();
            this.TuotteetPN.ResumeLayout(false);
            this.FooterPN.ResumeLayout(false);
            this.FooterPN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPN;
        private System.Windows.Forms.Label HeaderLB;
        private System.Windows.Forms.Button OstoskoriBT;
        private System.Windows.Forms.Button MaksaBT;
        private System.Windows.Forms.Button TuotteetBT;
        private System.Windows.Forms.SplitContainer TuotteetPN;
        private System.Windows.Forms.Button LisaaPizzaBT;
        private System.Windows.Forms.ComboBox PizzaCB;
        private System.Windows.Forms.Button LisaaTayteBT;
        private System.Windows.Forms.ComboBox TayteCB;
        private System.Windows.Forms.Panel FooterPN;
        private System.Windows.Forms.Label SummaLB;
        private System.Windows.Forms.Label SummaTitleLB;
        private System.Windows.Forms.Button VahvistukseenBT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

