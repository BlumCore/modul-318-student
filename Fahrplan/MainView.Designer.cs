namespace Fahrplan
{
    partial class MainView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_fehler = new System.Windows.Forms.TextBox();
            this.txt_nach = new System.Windows.Forms.ComboBox();
            this.txt_von = new System.Windows.Forms.ComboBox();
            this.lsb_resultat = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_suche = new System.Windows.Forms.Button();
            this.btn_abfahrtsortsuche = new System.Windows.Forms.Button();
            this.btn_neuesuche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_fehler);
            this.panel1.Controls.Add(this.txt_nach);
            this.panel1.Controls.Add(this.txt_von);
            this.panel1.Controls.Add(this.lsb_resultat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_suche);
            this.panel1.Controls.Add(this.btn_abfahrtsortsuche);
            this.panel1.Controls.Add(this.btn_neuesuche);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 1034);
            this.panel1.TabIndex = 0;
            // 
            // txt_fehler
            // 
            this.txt_fehler.BackColor = System.Drawing.Color.White;
            this.txt_fehler.Enabled = false;
            this.txt_fehler.Location = new System.Drawing.Point(82, 311);
            this.txt_fehler.Name = "txt_fehler";
            this.txt_fehler.ReadOnly = true;
            this.txt_fehler.Size = new System.Drawing.Size(1175, 31);
            this.txt_fehler.TabIndex = 11;
            this.txt_fehler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nach
            // 
            this.txt_nach.FormattingEnabled = true;
            this.txt_nach.Location = new System.Drawing.Point(242, 230);
            this.txt_nach.Name = "txt_nach";
            this.txt_nach.Size = new System.Drawing.Size(774, 33);
            this.txt_nach.TabIndex = 10;
            this.txt_nach.TextUpdate += new System.EventHandler(this.Txt_nach_TextUpdate);
            // 
            // txt_von
            // 
            this.txt_von.FormattingEnabled = true;
            this.txt_von.Location = new System.Drawing.Point(242, 134);
            this.txt_von.Name = "txt_von";
            this.txt_von.Size = new System.Drawing.Size(774, 33);
            this.txt_von.TabIndex = 9;
            this.txt_von.TextUpdate += new System.EventHandler(this.Txt_von_TextUpdate);
            // 
            // lsb_resultat
            // 
            this.lsb_resultat.FormattingEnabled = true;
            this.lsb_resultat.ItemHeight = 25;
            this.lsb_resultat.Location = new System.Drawing.Point(80, 510);
            this.lsb_resultat.Name = "lsb_resultat";
            this.lsb_resultat.Size = new System.Drawing.Size(1177, 454);
            this.lsb_resultat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(518, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 67);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fahrplan";
            // 
            // btn_suche
            // 
            this.btn_suche.BackColor = System.Drawing.Color.White;
            this.btn_suche.Location = new System.Drawing.Point(894, 361);
            this.btn_suche.Name = "btn_suche";
            this.btn_suche.Size = new System.Drawing.Size(363, 111);
            this.btn_suche.TabIndex = 6;
            this.btn_suche.Text = "Verbindung suchen";
            this.btn_suche.UseVisualStyleBackColor = false;
            this.btn_suche.Click += new System.EventHandler(this.Btn_suche_Click);
            // 
            // btn_abfahrtsortsuche
            // 
            this.btn_abfahrtsortsuche.BackColor = System.Drawing.Color.White;
            this.btn_abfahrtsortsuche.Location = new System.Drawing.Point(488, 361);
            this.btn_abfahrtsortsuche.Name = "btn_abfahrtsortsuche";
            this.btn_abfahrtsortsuche.Size = new System.Drawing.Size(363, 111);
            this.btn_abfahrtsortsuche.TabIndex = 5;
            this.btn_abfahrtsortsuche.Text = "Verbindung von abfahrsortsuchen";
            this.btn_abfahrtsortsuche.UseVisualStyleBackColor = false;
            this.btn_abfahrtsortsuche.Click += new System.EventHandler(this.Btn_abfahrtsortsuche_Click);
            // 
            // btn_neuesuche
            // 
            this.btn_neuesuche.BackColor = System.Drawing.Color.White;
            this.btn_neuesuche.Location = new System.Drawing.Point(80, 361);
            this.btn_neuesuche.Name = "btn_neuesuche";
            this.btn_neuesuche.Size = new System.Drawing.Size(363, 111);
            this.btn_neuesuche.TabIndex = 4;
            this.btn_neuesuche.Text = "Neue Suche";
            this.btn_neuesuche.UseVisualStyleBackColor = false;
            this.btn_neuesuche.Click += new System.EventHandler(this.Btn_neuesuche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1332, 1059);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Fahrplan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_suche;
        private System.Windows.Forms.Button btn_abfahrtsortsuche;
        private System.Windows.Forms.Button btn_neuesuche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsb_resultat;
        private System.Windows.Forms.ComboBox txt_von;
        private System.Windows.Forms.ComboBox txt_nach;
        private System.Windows.Forms.TextBox txt_fehler;
    }
}

