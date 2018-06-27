namespace planovac_2_0
{
    partial class frmUpravaAPridavani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpravaAPridavani));
            this.tbNazev = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lbHodina = new System.Windows.Forms.Label();
            this.lbMinuta = new System.Windows.Forms.Label();
            this.cbDruh = new System.Windows.Forms.ComboBox();
            this.rtbPodrobnosti = new System.Windows.Forms.RichTextBox();
            this.rbBezUrceniDruhu = new System.Windows.Forms.RadioButton();
            this.rbUrcitDruh = new System.Windows.Forms.RadioButton();
            this.rbJinyDruh = new System.Windows.Forms.RadioButton();
            this.tbJinyDruh = new System.Windows.Forms.TextBox();
            this.gbNazev = new System.Windows.Forms.GroupBox();
            this.gbDruh = new System.Windows.Forms.GroupBox();
            this.gbDatumCas = new System.Windows.Forms.GroupBox();
            this.nudMinuta = new planovac_2_0.CustomNumericUpDown();
            this.nudHodina = new planovac_2_0.CustomNumericUpDown();
            this.gbPodrobnosti = new System.Windows.Forms.GroupBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btKonec = new System.Windows.Forms.Button();
            this.gbNazev.SuspendLayout();
            this.gbDruh.SuspendLayout();
            this.gbDatumCas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHodina)).BeginInit();
            this.gbPodrobnosti.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNazev
            // 
            this.tbNazev.Location = new System.Drawing.Point(20, 19);
            this.tbNazev.Name = "tbNazev";
            this.tbNazev.Size = new System.Drawing.Size(405, 20);
            this.tbNazev.TabIndex = 1;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(27, 25);
            this.dtpDatum.MaxDate = new System.DateTime(2199, 12, 31, 0, 0, 0, 0);
            this.dtpDatum.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(170, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // lbHodina
            // 
            this.lbHodina.AutoSize = true;
            this.lbHodina.Location = new System.Drawing.Point(203, 27);
            this.lbHodina.Name = "lbHodina";
            this.lbHodina.Size = new System.Drawing.Size(44, 13);
            this.lbHodina.TabIndex = 7;
            this.lbHodina.Text = "Hodina:";
            // 
            // lbMinuta
            // 
            this.lbMinuta.AutoSize = true;
            this.lbMinuta.Location = new System.Drawing.Point(308, 27);
            this.lbMinuta.Name = "lbMinuta";
            this.lbMinuta.Size = new System.Drawing.Size(42, 13);
            this.lbMinuta.TabIndex = 8;
            this.lbMinuta.Text = "Minuta:";
            // 
            // cbDruh
            // 
            this.cbDruh.CausesValidation = false;
            this.cbDruh.Location = new System.Drawing.Point(142, 44);
            this.cbDruh.Name = "cbDruh";
            this.cbDruh.Size = new System.Drawing.Size(147, 21);
            this.cbDruh.TabIndex = 7;
            // 
            // rtbPodrobnosti
            // 
            this.rtbPodrobnosti.Location = new System.Drawing.Point(20, 19);
            this.rtbPodrobnosti.Name = "rtbPodrobnosti";
            this.rtbPodrobnosti.Size = new System.Drawing.Size(398, 49);
            this.rtbPodrobnosti.TabIndex = 9;
            this.rtbPodrobnosti.Text = "";
            // 
            // rbBezUrceniDruhu
            // 
            this.rbBezUrceniDruhu.AutoSize = true;
            this.rbBezUrceniDruhu.Location = new System.Drawing.Point(20, 22);
            this.rbBezUrceniDruhu.Name = "rbBezUrceniDruhu";
            this.rbBezUrceniDruhu.Size = new System.Drawing.Size(83, 17);
            this.rbBezUrceniDruhu.TabIndex = 13;
            this.rbBezUrceniDruhu.TabStop = true;
            this.rbBezUrceniDruhu.Text = "Neurčit druh";
            this.rbBezUrceniDruhu.UseVisualStyleBackColor = true;
            this.rbBezUrceniDruhu.CheckedChanged += new System.EventHandler(this.rbBezUrceniDruhu_CheckedChanged);
            // 
            // rbUrcitDruh
            // 
            this.rbUrcitDruh.AutoSize = true;
            this.rbUrcitDruh.Location = new System.Drawing.Point(20, 45);
            this.rbUrcitDruh.Name = "rbUrcitDruh";
            this.rbUrcitDruh.Size = new System.Drawing.Size(79, 17);
            this.rbUrcitDruh.TabIndex = 14;
            this.rbUrcitDruh.TabStop = true;
            this.rbUrcitDruh.Text = "Vybrat druh";
            this.rbUrcitDruh.UseVisualStyleBackColor = true;
            this.rbUrcitDruh.CheckedChanged += new System.EventHandler(this.rbUrcitDruh_CheckedChanged);
            // 
            // rbJinyDruh
            // 
            this.rbJinyDruh.AutoSize = true;
            this.rbJinyDruh.Location = new System.Drawing.Point(20, 68);
            this.rbJinyDruh.Name = "rbJinyDruh";
            this.rbJinyDruh.Size = new System.Drawing.Size(121, 17);
            this.rbJinyDruh.TabIndex = 15;
            this.rbJinyDruh.TabStop = true;
            this.rbJinyDruh.Text = "Definovat nový druh";
            this.rbJinyDruh.UseVisualStyleBackColor = true;
            this.rbJinyDruh.CheckedChanged += new System.EventHandler(this.rbJinyDruh_CheckedChanged);
            // 
            // tbJinyDruh
            // 
            this.tbJinyDruh.Location = new System.Drawing.Point(142, 67);
            this.tbJinyDruh.Name = "tbJinyDruh";
            this.tbJinyDruh.Size = new System.Drawing.Size(147, 20);
            this.tbJinyDruh.TabIndex = 16;
            // 
            // gbNazev
            // 
            this.gbNazev.Controls.Add(this.tbNazev);
            this.gbNazev.Location = new System.Drawing.Point(21, 4);
            this.gbNazev.Name = "gbNazev";
            this.gbNazev.Size = new System.Drawing.Size(431, 48);
            this.gbNazev.TabIndex = 17;
            this.gbNazev.TabStop = false;
            this.gbNazev.Text = "Název";
            // 
            // gbDruh
            // 
            this.gbDruh.Controls.Add(this.cbDruh);
            this.gbDruh.Controls.Add(this.rbBezUrceniDruhu);
            this.gbDruh.Controls.Add(this.tbJinyDruh);
            this.gbDruh.Controls.Add(this.rbUrcitDruh);
            this.gbDruh.Controls.Add(this.rbJinyDruh);
            this.gbDruh.Location = new System.Drawing.Point(21, 56);
            this.gbDruh.Name = "gbDruh";
            this.gbDruh.Size = new System.Drawing.Size(431, 99);
            this.gbDruh.TabIndex = 18;
            this.gbDruh.TabStop = false;
            this.gbDruh.Text = "Druh";
            // 
            // gbDatumCas
            // 
            this.gbDatumCas.Controls.Add(this.nudMinuta);
            this.gbDatumCas.Controls.Add(this.nudHodina);
            this.gbDatumCas.Controls.Add(this.dtpDatum);
            this.gbDatumCas.Controls.Add(this.lbHodina);
            this.gbDatumCas.Controls.Add(this.lbMinuta);
            this.gbDatumCas.Location = new System.Drawing.Point(21, 162);
            this.gbDatumCas.Name = "gbDatumCas";
            this.gbDatumCas.Size = new System.Drawing.Size(431, 59);
            this.gbDatumCas.TabIndex = 19;
            this.gbDatumCas.TabStop = false;
            this.gbDatumCas.Text = "Datum";
            // 
            // nudMinuta
            // 
            this.nudMinuta.Location = new System.Drawing.Point(356, 25);
            this.nudMinuta.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinuta.Name = "nudMinuta";
            this.nudMinuta.Size = new System.Drawing.Size(49, 20);
            this.nudMinuta.TabIndex = 11;
            // 
            // nudHodina
            // 
            this.nudHodina.Location = new System.Drawing.Point(250, 25);
            this.nudHodina.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHodina.Name = "nudHodina";
            this.nudHodina.Size = new System.Drawing.Size(52, 20);
            this.nudHodina.TabIndex = 10;
            // 
            // gbPodrobnosti
            // 
            this.gbPodrobnosti.Controls.Add(this.rtbPodrobnosti);
            this.gbPodrobnosti.Location = new System.Drawing.Point(28, 227);
            this.gbPodrobnosti.Name = "gbPodrobnosti";
            this.gbPodrobnosti.Size = new System.Drawing.Size(424, 78);
            this.gbPodrobnosti.TabIndex = 20;
            this.gbPodrobnosti.TabStop = false;
            this.gbPodrobnosti.Text = "Zde můžete zadat podrobnosti";
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(296, 311);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 21;
            this.btOK.Text = "&OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btKonec
            // 
            this.btKonec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btKonec.Location = new System.Drawing.Point(378, 311);
            this.btKonec.Name = "btKonec";
            this.btKonec.Size = new System.Drawing.Size(75, 23);
            this.btKonec.TabIndex = 22;
            this.btKonec.Text = "&Konec";
            this.btKonec.UseVisualStyleBackColor = true;
            // 
            // frmUpravaAPridavani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 345);
            this.Controls.Add(this.btKonec);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.gbPodrobnosti);
            this.Controls.Add(this.gbDatumCas);
            this.Controls.Add(this.gbDruh);
            this.Controls.Add(this.gbNazev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpravaAPridavani";
            this.Text = "Přidání nové položky";
            this.gbNazev.ResumeLayout(false);
            this.gbNazev.PerformLayout();
            this.gbDruh.ResumeLayout(false);
            this.gbDruh.PerformLayout();
            this.gbDatumCas.ResumeLayout(false);
            this.gbDatumCas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHodina)).EndInit();
            this.gbPodrobnosti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbNazev;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lbMinuta;
        private System.Windows.Forms.Label lbHodina;
        private System.Windows.Forms.ComboBox cbDruh;
        private System.Windows.Forms.RichTextBox rtbPodrobnosti;
        private System.Windows.Forms.RadioButton rbBezUrceniDruhu;
        private System.Windows.Forms.RadioButton rbUrcitDruh;
        private System.Windows.Forms.RadioButton rbJinyDruh;
        private System.Windows.Forms.TextBox tbJinyDruh;
        private System.Windows.Forms.GroupBox gbNazev;
        private System.Windows.Forms.GroupBox gbDruh;
        private System.Windows.Forms.GroupBox gbDatumCas;
        private System.Windows.Forms.GroupBox gbPodrobnosti;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btKonec;
        private CustomNumericUpDown nudMinuta;
        private CustomNumericUpDown nudHodina;
    }
}