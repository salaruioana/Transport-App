namespace TransportInfo
{
    partial class FormView
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
            this.panelOptiuni = new System.Windows.Forms.Panel();
            this.labelOptiuni = new System.Windows.Forms.Label();
            this.listBoxOptiuniDetaliate = new System.Windows.Forms.ListBox();
            this.listBoxModUtilizare = new System.Windows.Forms.ListBox();
            this.panelInfoRute = new System.Windows.Forms.Panel();
            this.labelOrasul2 = new System.Windows.Forms.Label();
            this.labelOrasul1 = new System.Windows.Forms.Label();
            this.labelInfoRute = new System.Windows.Forms.Label();
            this.buttonAfiseaza = new System.Windows.Forms.Button();
            this.comboBoxOrasul2 = new System.Windows.Forms.ComboBox();
            this.comboBoxOrasul1 = new System.Windows.Forms.ComboBox();
            this.panelAdaugareOras = new System.Windows.Forms.Panel();
            this.labelAdaugare = new System.Windows.Forms.Label();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.panelStergere = new System.Windows.Forms.Panel();
            this.labelStergere = new System.Windows.Forms.Label();
            this.comboBoxStergereOras = new System.Windows.Forms.ComboBox();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.richTextBoxContinut = new System.Windows.Forms.RichTextBox();
            this.textBoxAlegereOras = new System.Windows.Forms.TextBox();
            this.panelOptiuni.SuspendLayout();
            this.panelInfoRute.SuspendLayout();
            this.panelAdaugareOras.SuspendLayout();
            this.panelStergere.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOptiuni
            // 
            this.panelOptiuni.Controls.Add(this.labelOptiuni);
            this.panelOptiuni.Controls.Add(this.listBoxOptiuniDetaliate);
            this.panelOptiuni.Controls.Add(this.listBoxModUtilizare);
            this.panelOptiuni.Location = new System.Drawing.Point(7, 12);
            this.panelOptiuni.Name = "panelOptiuni";
            this.panelOptiuni.Size = new System.Drawing.Size(397, 164);
            this.panelOptiuni.TabIndex = 0;
            // 
            // labelOptiuni
            // 
            this.labelOptiuni.AutoSize = true;
            this.labelOptiuni.Location = new System.Drawing.Point(9, 11);
            this.labelOptiuni.Name = "labelOptiuni";
            this.labelOptiuni.Size = new System.Drawing.Size(48, 16);
            this.labelOptiuni.TabIndex = 2;
            this.labelOptiuni.Text = "Optiuni";
            // 
            // listBoxOptiuniDetaliate
            // 
            this.listBoxOptiuniDetaliate.FormattingEnabled = true;
            this.listBoxOptiuniDetaliate.ItemHeight = 16;
            this.listBoxOptiuniDetaliate.Location = new System.Drawing.Point(144, 32);
            this.listBoxOptiuniDetaliate.Name = "listBoxOptiuniDetaliate";
            this.listBoxOptiuniDetaliate.Size = new System.Drawing.Size(250, 116);
            this.listBoxOptiuniDetaliate.TabIndex = 1;
            this.listBoxOptiuniDetaliate.SelectedIndexChanged += new System.EventHandler(this.listBoxOptiuniDetaliate_SelectedIndexChanged);
            // 
            // listBoxModUtilizare
            // 
            this.listBoxModUtilizare.FormattingEnabled = true;
            this.listBoxModUtilizare.ItemHeight = 16;
            this.listBoxModUtilizare.Location = new System.Drawing.Point(5, 32);
            this.listBoxModUtilizare.Name = "listBoxModUtilizare";
            this.listBoxModUtilizare.Size = new System.Drawing.Size(133, 116);
            this.listBoxModUtilizare.TabIndex = 0;
            this.listBoxModUtilizare.SelectedIndexChanged += new System.EventHandler(this.listBoxModUtilizare_SelectedIndexChanged);
            // 
            // panelInfoRute
            // 
            this.panelInfoRute.Controls.Add(this.labelOrasul2);
            this.panelInfoRute.Controls.Add(this.labelOrasul1);
            this.panelInfoRute.Controls.Add(this.labelInfoRute);
            this.panelInfoRute.Controls.Add(this.buttonAfiseaza);
            this.panelInfoRute.Controls.Add(this.comboBoxOrasul2);
            this.panelInfoRute.Controls.Add(this.comboBoxOrasul1);
            this.panelInfoRute.Location = new System.Drawing.Point(410, 14);
            this.panelInfoRute.Name = "panelInfoRute";
            this.panelInfoRute.Size = new System.Drawing.Size(377, 165);
            this.panelInfoRute.TabIndex = 1;
            // 
            // labelOrasul2
            // 
            this.labelOrasul2.AutoSize = true;
            this.labelOrasul2.Location = new System.Drawing.Point(22, 92);
            this.labelOrasul2.Name = "labelOrasul2";
            this.labelOrasul2.Size = new System.Drawing.Size(59, 16);
            this.labelOrasul2.TabIndex = 5;
            this.labelOrasul2.Text = "Orasul 2 ";
            // 
            // labelOrasul1
            // 
            this.labelOrasul1.AutoSize = true;
            this.labelOrasul1.Location = new System.Drawing.Point(22, 31);
            this.labelOrasul1.Name = "labelOrasul1";
            this.labelOrasul1.Size = new System.Drawing.Size(59, 16);
            this.labelOrasul1.TabIndex = 4;
            this.labelOrasul1.Text = "Orasul 1 ";
            // 
            // labelInfoRute
            // 
            this.labelInfoRute.AutoSize = true;
            this.labelInfoRute.Location = new System.Drawing.Point(7, 4);
            this.labelInfoRute.Name = "labelInfoRute";
            this.labelInfoRute.Size = new System.Drawing.Size(53, 16);
            this.labelInfoRute.TabIndex = 3;
            this.labelInfoRute.Text = "Info rute";
            // 
            // buttonAfiseaza
            // 
            this.buttonAfiseaza.Location = new System.Drawing.Point(238, 85);
            this.buttonAfiseaza.Name = "buttonAfiseaza";
            this.buttonAfiseaza.Size = new System.Drawing.Size(126, 31);
            this.buttonAfiseaza.TabIndex = 2;
            this.buttonAfiseaza.Text = "Afiseaza";
            this.buttonAfiseaza.UseVisualStyleBackColor = true;
            this.buttonAfiseaza.Click += new System.EventHandler(this.buttonAfiseaza_Click);
            // 
            // comboBoxOrasul2
            // 
            this.comboBoxOrasul2.FormattingEnabled = true;
            this.comboBoxOrasul2.Location = new System.Drawing.Point(17, 122);
            this.comboBoxOrasul2.Name = "comboBoxOrasul2";
            this.comboBoxOrasul2.Size = new System.Drawing.Size(205, 24);
            this.comboBoxOrasul2.TabIndex = 1;
            // 
            // comboBoxOrasul1
            // 
            this.comboBoxOrasul1.FormattingEnabled = true;
            this.comboBoxOrasul1.Location = new System.Drawing.Point(16, 53);
            this.comboBoxOrasul1.Name = "comboBoxOrasul1";
            this.comboBoxOrasul1.Size = new System.Drawing.Size(206, 24);
            this.comboBoxOrasul1.TabIndex = 0;
            // 
            // panelAdaugareOras
            // 
            this.panelAdaugareOras.Controls.Add(this.textBoxAlegereOras);
            this.panelAdaugareOras.Controls.Add(this.labelAdaugare);
            this.panelAdaugareOras.Controls.Add(this.buttonAdauga);
            this.panelAdaugareOras.Location = new System.Drawing.Point(7, 182);
            this.panelAdaugareOras.Name = "panelAdaugareOras";
            this.panelAdaugareOras.Size = new System.Drawing.Size(397, 80);
            this.panelAdaugareOras.TabIndex = 2;
            // 
            // labelAdaugare
            // 
            this.labelAdaugare.AutoSize = true;
            this.labelAdaugare.Location = new System.Drawing.Point(10, 13);
            this.labelAdaugare.Name = "labelAdaugare";
            this.labelAdaugare.Size = new System.Drawing.Size(67, 16);
            this.labelAdaugare.TabIndex = 2;
            this.labelAdaugare.Text = "Adaugare";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(292, 38);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(93, 28);
            this.buttonAdauga.TabIndex = 1;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // panelStergere
            // 
            this.panelStergere.Controls.Add(this.labelStergere);
            this.panelStergere.Controls.Add(this.comboBoxStergereOras);
            this.panelStergere.Controls.Add(this.buttonSterge);
            this.panelStergere.Location = new System.Drawing.Point(410, 185);
            this.panelStergere.Name = "panelStergere";
            this.panelStergere.Size = new System.Drawing.Size(376, 77);
            this.panelStergere.TabIndex = 3;
            // 
            // labelStergere
            // 
            this.labelStergere.AutoSize = true;
            this.labelStergere.Location = new System.Drawing.Point(11, 12);
            this.labelStergere.Name = "labelStergere";
            this.labelStergere.Size = new System.Drawing.Size(59, 16);
            this.labelStergere.TabIndex = 2;
            this.labelStergere.Text = "Stergere";
            // 
            // comboBoxStergereOras
            // 
            this.comboBoxStergereOras.FormattingEnabled = true;
            this.comboBoxStergereOras.Location = new System.Drawing.Point(16, 39);
            this.comboBoxStergereOras.Name = "comboBoxStergereOras";
            this.comboBoxStergereOras.Size = new System.Drawing.Size(230, 24);
            this.comboBoxStergereOras.TabIndex = 1;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(271, 38);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(93, 27);
            this.buttonSterge.TabIndex = 0;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // richTextBoxContinut
            // 
            this.richTextBoxContinut.Location = new System.Drawing.Point(6, 268);
            this.richTextBoxContinut.Name = "richTextBoxContinut";
            this.richTextBoxContinut.Size = new System.Drawing.Size(781, 177);
            this.richTextBoxContinut.TabIndex = 4;
            this.richTextBoxContinut.Text = "";
            // 
            // textBoxAlegereOras
            // 
            this.textBoxAlegereOras.Location = new System.Drawing.Point(25, 41);
            this.textBoxAlegereOras.Name = "textBoxAlegereOras";
            this.textBoxAlegereOras.Size = new System.Drawing.Size(254, 22);
            this.textBoxAlegereOras.TabIndex = 3;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxContinut);
            this.Controls.Add(this.panelStergere);
            this.Controls.Add(this.panelAdaugareOras);
            this.Controls.Add(this.panelInfoRute);
            this.Controls.Add(this.panelOptiuni);
            this.Name = "FormView";
            this.Text = "Transport Info";
            this.panelOptiuni.ResumeLayout(false);
            this.panelOptiuni.PerformLayout();
            this.panelInfoRute.ResumeLayout(false);
            this.panelInfoRute.PerformLayout();
            this.panelAdaugareOras.ResumeLayout(false);
            this.panelAdaugareOras.PerformLayout();
            this.panelStergere.ResumeLayout(false);
            this.panelStergere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptiuni;
        private System.Windows.Forms.ListBox listBoxModUtilizare;
        private System.Windows.Forms.Panel panelInfoRute;
        private System.Windows.Forms.Panel panelAdaugareOras;
        private System.Windows.Forms.Panel panelStergere;
        private System.Windows.Forms.ListBox listBoxOptiuniDetaliate;
        private System.Windows.Forms.Button buttonAfiseaza;
        private System.Windows.Forms.ComboBox comboBoxOrasul2;
        private System.Windows.Forms.ComboBox comboBoxOrasul1;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.ComboBox comboBoxStergereOras;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.RichTextBox richTextBoxContinut;
        private System.Windows.Forms.Label labelOptiuni;
        private System.Windows.Forms.Label labelOrasul2;
        private System.Windows.Forms.Label labelOrasul1;
        private System.Windows.Forms.Label labelInfoRute;
        private System.Windows.Forms.Label labelAdaugare;
        private System.Windows.Forms.Label labelStergere;
        private System.Windows.Forms.TextBox textBoxAlegereOras;
    }
}