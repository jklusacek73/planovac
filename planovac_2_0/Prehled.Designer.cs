namespace planovac_2_0
{
    partial class frmTrideni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrideni));
            this.gbTrideni = new System.Windows.Forms.GroupBox();
            this.cbDruhy = new System.Windows.Forms.ComboBox();
            this.rbTridit = new System.Windows.Forms.RadioButton();
            this.rbPrazdneDruhy = new System.Windows.Forms.RadioButton();
            this.rbNetridit = new System.Windows.Forms.RadioButton();
            this.tbcTrideni = new System.Windows.Forms.TabControl();
            this.tpUkoly = new System.Windows.Forms.TabPage();
            this.lbZadneUkoly = new System.Windows.Forms.Label();
            this.lvPrehledUkolu = new System.Windows.Forms.ListView();
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.druh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpUdalosti = new System.Windows.Forms.TabPage();
            this.lbZadneUdalosti = new System.Windows.Forms.Label();
            this.lvPrehledUdalosti = new System.Windows.Forms.ListView();
            this.datumUdalosti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DruhUdalosti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazevUdalosti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTrideni.SuspendLayout();
            this.tbcTrideni.SuspendLayout();
            this.tpUkoly.SuspendLayout();
            this.tpUdalosti.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTrideni
            // 
            this.gbTrideni.Controls.Add(this.cbDruhy);
            this.gbTrideni.Controls.Add(this.rbTridit);
            this.gbTrideni.Controls.Add(this.rbPrazdneDruhy);
            this.gbTrideni.Controls.Add(this.rbNetridit);
            this.gbTrideni.Location = new System.Drawing.Point(13, 13);
            this.gbTrideni.Name = "gbTrideni";
            this.gbTrideni.Size = new System.Drawing.Size(569, 48);
            this.gbTrideni.TabIndex = 0;
            this.gbTrideni.TabStop = false;
            this.gbTrideni.Text = "Třídění úkolů podle druhu";
            // 
            // cbDruhy
            // 
            this.cbDruhy.FormattingEnabled = true;
            this.cbDruhy.Location = new System.Drawing.Point(391, 17);
            this.cbDruhy.Name = "cbDruhy";
            this.cbDruhy.Size = new System.Drawing.Size(129, 21);
            this.cbDruhy.TabIndex = 3;
            this.cbDruhy.SelectedIndexChanged += new System.EventHandler(this.cbDruhy_SelectedIndexChanged);
            // 
            // rbTridit
            // 
            this.rbTridit.AutoSize = true;
            this.rbTridit.Location = new System.Drawing.Point(303, 18);
            this.rbTridit.Name = "rbTridit";
            this.rbTridit.Size = new System.Drawing.Size(82, 17);
            this.rbTridit.TabIndex = 2;
            this.rbTridit.TabStop = true;
            this.rbTridit.Text = "Vybrat druh:";
            this.rbTridit.UseVisualStyleBackColor = true;
            this.rbTridit.CheckedChanged += new System.EventHandler(this.rbTridit_CheckedChanged);
            // 
            // rbPrazdneDruhy
            // 
            this.rbPrazdneDruhy.AutoSize = true;
            this.rbPrazdneDruhy.Location = new System.Drawing.Point(144, 18);
            this.rbPrazdneDruhy.Name = "rbPrazdneDruhy";
            this.rbPrazdneDruhy.Size = new System.Drawing.Size(107, 17);
            this.rbPrazdneDruhy.TabIndex = 1;
            this.rbPrazdneDruhy.TabStop = true;
            this.rbPrazdneDruhy.Text = "Bez určení druhů";
            this.rbPrazdneDruhy.UseVisualStyleBackColor = true;
            this.rbPrazdneDruhy.CheckedChanged += new System.EventHandler(this.rbPrazdneDruhy_CheckedChanged);
            // 
            // rbNetridit
            // 
            this.rbNetridit.AutoSize = true;
            this.rbNetridit.Location = new System.Drawing.Point(27, 18);
            this.rbNetridit.Name = "rbNetridit";
            this.rbNetridit.Size = new System.Drawing.Size(61, 17);
            this.rbNetridit.TabIndex = 0;
            this.rbNetridit.TabStop = true;
            this.rbNetridit.Text = "Netřídit";
            this.rbNetridit.UseVisualStyleBackColor = true;
            this.rbNetridit.CheckedChanged += new System.EventHandler(this.rbNetridit_CheckedChanged);
            // 
            // tbcTrideni
            // 
            this.tbcTrideni.Controls.Add(this.tpUkoly);
            this.tbcTrideni.Controls.Add(this.tpUdalosti);
            this.tbcTrideni.Location = new System.Drawing.Point(13, 68);
            this.tbcTrideni.Name = "tbcTrideni";
            this.tbcTrideni.SelectedIndex = 0;
            this.tbcTrideni.Size = new System.Drawing.Size(569, 181);
            this.tbcTrideni.TabIndex = 1;
            // 
            // tpUkoly
            // 
            this.tpUkoly.Controls.Add(this.lbZadneUkoly);
            this.tpUkoly.Controls.Add(this.lvPrehledUkolu);
            this.tpUkoly.Location = new System.Drawing.Point(4, 22);
            this.tpUkoly.Name = "tpUkoly";
            this.tpUkoly.Padding = new System.Windows.Forms.Padding(3);
            this.tpUkoly.Size = new System.Drawing.Size(561, 155);
            this.tpUkoly.TabIndex = 0;
            this.tpUkoly.Text = "Úkoly";
            this.tpUkoly.UseVisualStyleBackColor = true;
            // 
            // lbZadneUkoly
            // 
            this.lbZadneUkoly.AutoSize = true;
            this.lbZadneUkoly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZadneUkoly.Location = new System.Drawing.Point(174, 75);
            this.lbZadneUkoly.Name = "lbZadneUkoly";
            this.lbZadneUkoly.Size = new System.Drawing.Size(192, 16);
            this.lbZadneUkoly.TabIndex = 5;
            this.lbZadneUkoly.Text = "Nejsou k dispozici žádné úkoly";
            this.lbZadneUkoly.Visible = false;
            // 
            // lvPrehledUkolu
            // 
            this.lvPrehledUkolu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.datum,
            this.cas,
            this.druh,
            this.nazev});
            this.lvPrehledUkolu.Location = new System.Drawing.Point(3, 3);
            this.lvPrehledUkolu.Name = "lvPrehledUkolu";
            this.lvPrehledUkolu.Size = new System.Drawing.Size(555, 149);
            this.lvPrehledUkolu.TabIndex = 0;
            this.lvPrehledUkolu.UseCompatibleStateImageBehavior = false;
            this.lvPrehledUkolu.View = System.Windows.Forms.View.Details;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 110;
            // 
            // cas
            // 
            this.cas.Text = "Čas";
            this.cas.Width = 50;
            // 
            // druh
            // 
            this.druh.Text = "Druh";
            this.druh.Width = 100;
            // 
            // nazev
            // 
            this.nazev.Text = "Název";
            this.nazev.Width = 290;
            // 
            // tpUdalosti
            // 
            this.tpUdalosti.Controls.Add(this.lbZadneUdalosti);
            this.tpUdalosti.Controls.Add(this.lvPrehledUdalosti);
            this.tpUdalosti.Location = new System.Drawing.Point(4, 22);
            this.tpUdalosti.Name = "tpUdalosti";
            this.tpUdalosti.Padding = new System.Windows.Forms.Padding(3);
            this.tpUdalosti.Size = new System.Drawing.Size(561, 155);
            this.tpUdalosti.TabIndex = 1;
            this.tpUdalosti.Text = "Události";
            this.tpUdalosti.UseVisualStyleBackColor = true;
            // 
            // lbZadneUdalosti
            // 
            this.lbZadneUdalosti.AutoSize = true;
            this.lbZadneUdalosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZadneUdalosti.Location = new System.Drawing.Point(171, 64);
            this.lbZadneUdalosti.Name = "lbZadneUdalosti";
            this.lbZadneUdalosti.Size = new System.Drawing.Size(207, 16);
            this.lbZadneUdalosti.TabIndex = 6;
            this.lbZadneUdalosti.Text = "Nejsou k dispozici žádné události";
            this.lbZadneUdalosti.Visible = false;
            // 
            // lvPrehledUdalosti
            // 
            this.lvPrehledUdalosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.datumUdalosti,
            this.DruhUdalosti,
            this.NazevUdalosti});
            this.lvPrehledUdalosti.Location = new System.Drawing.Point(3, 3);
            this.lvPrehledUdalosti.Name = "lvPrehledUdalosti";
            this.lvPrehledUdalosti.Size = new System.Drawing.Size(555, 149);
            this.lvPrehledUdalosti.TabIndex = 0;
            this.lvPrehledUdalosti.UseCompatibleStateImageBehavior = false;
            this.lvPrehledUdalosti.View = System.Windows.Forms.View.Details;
            // 
            // datumUdalosti
            // 
            this.datumUdalosti.Text = "Datum";
            this.datumUdalosti.Width = 110;
            // 
            // DruhUdalosti
            // 
            this.DruhUdalosti.Text = "Druh";
            this.DruhUdalosti.Width = 100;
            // 
            // NazevUdalosti
            // 
            this.NazevUdalosti.Text = "Název";
            this.NazevUdalosti.Width = 337;
            // 
            // frmTrideni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 261);
            this.Controls.Add(this.tbcTrideni);
            this.Controls.Add(this.gbTrideni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrideni";
            this.Text = "Přehled všech úkolů a událostí";
            this.gbTrideni.ResumeLayout(false);
            this.gbTrideni.PerformLayout();
            this.tbcTrideni.ResumeLayout(false);
            this.tpUkoly.ResumeLayout(false);
            this.tpUkoly.PerformLayout();
            this.tpUdalosti.ResumeLayout(false);
            this.tpUdalosti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTrideni;
        private System.Windows.Forms.RadioButton rbNetridit;
        private System.Windows.Forms.RadioButton rbPrazdneDruhy;
        private System.Windows.Forms.ComboBox cbDruhy;
        private System.Windows.Forms.RadioButton rbTridit;
        private System.Windows.Forms.TabControl tbcTrideni;
        private System.Windows.Forms.TabPage tpUkoly;
        private System.Windows.Forms.ListView lvPrehledUkolu;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader cas;
        private System.Windows.Forms.ColumnHeader druh;
        private System.Windows.Forms.ColumnHeader nazev;
        private System.Windows.Forms.TabPage tpUdalosti;
        private System.Windows.Forms.ListView lvPrehledUdalosti;
        private System.Windows.Forms.ColumnHeader datumUdalosti;
        private System.Windows.Forms.ColumnHeader DruhUdalosti;
        private System.Windows.Forms.ColumnHeader NazevUdalosti;
        private System.Windows.Forms.Label lbZadneUkoly;
        private System.Windows.Forms.Label lbZadneUdalosti;
    }
}