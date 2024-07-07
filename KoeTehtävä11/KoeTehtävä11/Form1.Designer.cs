namespace KoeTehtävä11
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
            this.label1 = new System.Windows.Forms.Label();
            this.määräEURO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Painike_dollari = new System.Windows.Forms.RadioButton();
            this.Painike_ruplat = new System.Windows.Forms.RadioButton();
            this.Painike_kruunu = new System.Windows.Forms.RadioButton();
            this.Muunnos = new System.Windows.Forms.ListBox();
            this.Painike_Muunna = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "€ ";
            // 
            // määräEURO
            // 
            this.määräEURO.Location = new System.Drawing.Point(34, 24);
            this.määräEURO.Name = "määräEURO";
            this.määräEURO.Size = new System.Drawing.Size(121, 20);
            this.määräEURO.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Painike_dollari);
            this.groupBox1.Controls.Add(this.Painike_ruplat);
            this.groupBox1.Controls.Add(this.Painike_kruunu);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valuutta mihin muunnos tehdään";
            // 
            // Painike_dollari
            // 
            this.Painike_dollari.AutoSize = true;
            this.Painike_dollari.Location = new System.Drawing.Point(7, 65);
            this.Painike_dollari.Name = "Painike_dollari";
            this.Painike_dollari.Size = new System.Drawing.Size(73, 17);
            this.Painike_dollari.TabIndex = 2;
            this.Painike_dollari.TabStop = true;
            this.Painike_dollari.Text = "US -dollari";
            this.Painike_dollari.UseVisualStyleBackColor = true;
            // 
            // Painike_ruplat
            // 
            this.Painike_ruplat.AutoSize = true;
            this.Painike_ruplat.Location = new System.Drawing.Point(7, 42);
            this.Painike_ruplat.Name = "Painike_ruplat";
            this.Painike_ruplat.Size = new System.Drawing.Size(53, 17);
            this.Painike_ruplat.TabIndex = 1;
            this.Painike_ruplat.TabStop = true;
            this.Painike_ruplat.Text = "Rupla";
            this.Painike_ruplat.UseVisualStyleBackColor = true;
            // 
            // Painike_kruunu
            // 
            this.Painike_kruunu.AutoSize = true;
            this.Painike_kruunu.Location = new System.Drawing.Point(7, 19);
            this.Painike_kruunu.Name = "Painike_kruunu";
            this.Painike_kruunu.Size = new System.Drawing.Size(59, 17);
            this.Painike_kruunu.TabIndex = 0;
            this.Painike_kruunu.TabStop = true;
            this.Painike_kruunu.Text = "Kruunu";
            this.Painike_kruunu.UseVisualStyleBackColor = true;
            // 
            // Muunnos
            // 
            this.Muunnos.FormattingEnabled = true;
            this.Muunnos.Location = new System.Drawing.Point(249, 66);
            this.Muunnos.Name = "Muunnos";
            this.Muunnos.Size = new System.Drawing.Size(113, 82);
            this.Muunnos.TabIndex = 3;
            this.Muunnos.SelectedIndexChanged += new System.EventHandler(this.Muunnos_SelectedIndexChanged);
            // 
            // Painike_Muunna
            // 
            this.Painike_Muunna.Location = new System.Drawing.Point(79, 181);
            this.Painike_Muunna.Name = "Painike_Muunna";
            this.Painike_Muunna.Size = new System.Drawing.Size(255, 23);
            this.Painike_Muunna.TabIndex = 4;
            this.Painike_Muunna.Text = "Muunna";
            this.Painike_Muunna.UseVisualStyleBackColor = true;
            this.Painike_Muunna.Click += new System.EventHandler(this.Painike_Muunna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 228);
            this.Controls.Add(this.Painike_Muunna);
            this.Controls.Add(this.Muunnos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.määräEURO);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox määräEURO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Painike_dollari;
        private System.Windows.Forms.RadioButton Painike_ruplat;
        private System.Windows.Forms.RadioButton Painike_kruunu;
        private System.Windows.Forms.ListBox Muunnos;
        private System.Windows.Forms.Button Painike_Muunna;
    }
}

