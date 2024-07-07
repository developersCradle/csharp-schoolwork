namespace KoeTeht10
{
    partial class KoeTeht10
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
            this.TekstiBoxi_Leveys = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TekstiBoxi_Pituus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TekstiBoxi_Korkeus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Painike_Laske = new System.Windows.Forms.Button();
            this.Tulokset = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TekstiBoxi_Leveys
            // 
            this.TekstiBoxi_Leveys.Location = new System.Drawing.Point(12, 47);
            this.TekstiBoxi_Leveys.Name = "TekstiBoxi_Leveys";
            this.TekstiBoxi_Leveys.Size = new System.Drawing.Size(100, 20);
            this.TekstiBoxi_Leveys.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leveys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pituus";
            // 
            // TekstiBoxi_Pituus
            // 
            this.TekstiBoxi_Pituus.Location = new System.Drawing.Point(12, 89);
            this.TekstiBoxi_Pituus.Name = "TekstiBoxi_Pituus";
            this.TekstiBoxi_Pituus.Size = new System.Drawing.Size(100, 20);
            this.TekstiBoxi_Pituus.TabIndex = 2;
            this.TekstiBoxi_Pituus.TextChanged += new System.EventHandler(this.TextiBoxi_Pituus_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Korkeus";
            // 
            // TekstiBoxi_Korkeus
            // 
            this.TekstiBoxi_Korkeus.Location = new System.Drawing.Point(12, 126);
            this.TekstiBoxi_Korkeus.Name = "TekstiBoxi_Korkeus";
            this.TekstiBoxi_Korkeus.Size = new System.Drawing.Size(100, 20);
            this.TekstiBoxi_Korkeus.TabIndex = 4;
            this.TekstiBoxi_Korkeus.TextChanged += new System.EventHandler(this.TextiBoxi_Korkeus_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Laskuri";
            // 
            // Painike_Laske
            // 
            this.Painike_Laske.Location = new System.Drawing.Point(12, 153);
            this.Painike_Laske.Name = "Painike_Laske";
            this.Painike_Laske.Size = new System.Drawing.Size(100, 67);
            this.Painike_Laske.TabIndex = 7;
            this.Painike_Laske.Text = "Laske";
            this.Painike_Laske.UseVisualStyleBackColor = true;
            this.Painike_Laske.Click += new System.EventHandler(this.Painike_Laske_Click);
            // 
            // Tulokset
            // 
            this.Tulokset.FormattingEnabled = true;
            this.Tulokset.Location = new System.Drawing.Point(118, 31);
            this.Tulokset.Name = "Tulokset";
            this.Tulokset.Size = new System.Drawing.Size(162, 186);
            this.Tulokset.TabIndex = 8;
            // 
            // KoeTeht10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.Tulokset);
            this.Controls.Add(this.Painike_Laske);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TekstiBoxi_Korkeus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TekstiBoxi_Pituus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TekstiBoxi_Leveys);
            this.Name = "KoeTeht10";
            this.Text = "KoeTeht10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TekstiBoxi_Leveys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TekstiBoxi_Pituus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TekstiBoxi_Korkeus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Painike_Laske;
        private System.Windows.Forms.ListBox Tulokset;
    }
}

