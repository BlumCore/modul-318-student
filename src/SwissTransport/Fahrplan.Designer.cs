namespace SwissTransport
{
    partial class Fahrplan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_neuesuche = new System.Windows.Forms.Button();
            this.btn_abfahrtortsuchen = new System.Windows.Forms.Button();
            this.btn_suche = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_suche);
            this.panel1.Controls.Add(this.btn_abfahrtortsuchen);
            this.panel1.Controls.Add(this.btn_neuesuche);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 920);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrplan";
            // 
            // btn_neuesuche
            // 
            this.btn_neuesuche.Location = new System.Drawing.Point(146, 694);
            this.btn_neuesuche.Name = "btn_neuesuche";
            this.btn_neuesuche.Size = new System.Drawing.Size(361, 111);
            this.btn_neuesuche.TabIndex = 1;
            this.btn_neuesuche.Text = "Neue Suche";
            this.btn_neuesuche.UseVisualStyleBackColor = true;
            // 
            // btn_abfahrtortsuchen
            // 
            this.btn_abfahrtortsuchen.Location = new System.Drawing.Point(582, 694);
            this.btn_abfahrtortsuchen.Name = "btn_abfahrtortsuchen";
            this.btn_abfahrtortsuchen.Size = new System.Drawing.Size(361, 111);
            this.btn_abfahrtortsuchen.TabIndex = 2;
            this.btn_abfahrtortsuchen.Text = "Verbindung von Abfahrtsort suchen";
            this.btn_abfahrtortsuchen.UseVisualStyleBackColor = true;
            // 
            // btn_suche
            // 
            this.btn_suche.Location = new System.Drawing.Point(1046, 694);
            this.btn_suche.Name = "btn_suche";
            this.btn_suche.Size = new System.Drawing.Size(361, 111);
            this.btn_suche.TabIndex = 3;
            this.btn_suche.Text = "Verbindung Suchen";
            this.btn_suche.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(781, 31);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(781, 31);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1020, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Von";
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 923);
            this.Controls.Add(this.panel1);
            this.Name = "Fahrplan";
            this.Text = "Fahrplan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_suche;
        private System.Windows.Forms.Button btn_abfahrtortsuchen;
        private System.Windows.Forms.Button btn_neuesuche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}