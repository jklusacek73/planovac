namespace planovac_2_0
{
    partial class planovac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(planovac));
            this.kalendar = new System.Windows.Forms.MonthCalendar();
            this.lvUkoly = new System.Windows.Forms.ListView();
            this.cas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.druh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUdalosti = new System.Windows.Forms.ListView();
            this.druhUdalosti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazevUdalosti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcHlavniKarta = new System.Windows.Forms.TabControl();
            this.tpUkoly = new System.Windows.Forms.TabPage();
            this.btInfoUkol = new System.Windows.Forms.Button();
            this.btOdstranitUkol = new System.Windows.Forms.Button();
            this.btUpravitUkol = new System.Windows.Forms.Button();
            this.btNovyUkol = new System.Windows.Forms.Button();
            this.lbPodrobnostiUkol = new System.Windows.Forms.Label();
            this.lbPodrobnostiUkolNazev = new System.Windows.Forms.Label();
            this.lbDatumUkoly = new System.Windows.Forms.Label();
            this.lbZadneUkoly = new System.Windows.Forms.Label();
            this.tpUdalosti = new System.Windows.Forms.TabPage();
            this.btInfoUdalost = new System.Windows.Forms.Button();
            this.btOdstranitUdalost = new System.Windows.Forms.Button();
            this.btUpravitUdalost = new System.Windows.Forms.Button();
            this.btNovaUdalost = new System.Windows.Forms.Button();
            this.lbUdalostPodrobnosti = new System.Windows.Forms.Label();
            this.lbZadneUdalosti = new System.Windows.Forms.Label();
            this.lbUdalostPodrobnostiNazev = new System.Windows.Forms.Label();
            this.lbDatumUdalosti = new System.Windows.Forms.Label();
            this.lbPrani = new System.Windows.Forms.Label();
            this.mnMenu = new System.Windows.Forms.MenuStrip();
            this.přehledyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přehledÚkolůAUdálostíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podleDruhuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.správceDruhůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.práceSDatyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importovatXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.úkolyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.událostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportovatXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.úkolyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.událostiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcHlavniKarta.SuspendLayout();
            this.tpUkoly.SuspendLayout();
            this.tpUdalosti.SuspendLayout();
            this.mnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // kalendar
            // 
            this.kalendar.Location = new System.Drawing.Point(454, 59);
            this.kalendar.MaxDate = new System.DateTime(2199, 12, 31, 0, 0, 0, 0);
            this.kalendar.MaxSelectionCount = 1;
            this.kalendar.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.kalendar.Name = "kalendar";
            this.kalendar.TabIndex = 0;
            this.kalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.kalendar_DateChanged);
            // 
            // lvUkoly
            // 
            this.lvUkoly.BackColor = System.Drawing.Color.White;
            this.lvUkoly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cas,
            this.druh,
            this.nazev});
            this.lvUkoly.Location = new System.Drawing.Point(6, 29);
            this.lvUkoly.Name = "lvUkoly";
            this.lvUkoly.Size = new System.Drawing.Size(414, 123);
            this.lvUkoly.TabIndex = 2;
            this.lvUkoly.UseCompatibleStateImageBehavior = false;
            this.lvUkoly.View = System.Windows.Forms.View.Details;
            this.lvUkoly.SelectedIndexChanged += new System.EventHandler(this.lvUkoly_SelectedIndexChanged);
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
            this.nazev.Text = "Název úkolu";
            this.nazev.Width = 259;
            // 
            // lvUdalosti
            // 
            this.lvUdalosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.druhUdalosti,
            this.nazevUdalosti});
            this.lvUdalosti.Location = new System.Drawing.Point(6, 29);
            this.lvUdalosti.Name = "lvUdalosti";
            this.lvUdalosti.Size = new System.Drawing.Size(414, 123);
            this.lvUdalosti.TabIndex = 0;
            this.lvUdalosti.UseCompatibleStateImageBehavior = false;
            this.lvUdalosti.View = System.Windows.Forms.View.Details;
            this.lvUdalosti.SelectedIndexChanged += new System.EventHandler(this.lvUdalosti_SelectedIndexChanged);
            // 
            // druhUdalosti
            // 
            this.druhUdalosti.Text = "Druh";
            this.druhUdalosti.Width = 100;
            // 
            // nazevUdalosti
            // 
            this.nazevUdalosti.Text = "Název události";
            this.nazevUdalosti.Width = 309;
            // 
            // tcHlavniKarta
            // 
            this.tcHlavniKarta.Controls.Add(this.tpUkoly);
            this.tcHlavniKarta.Controls.Add(this.tpUdalosti);
            this.tcHlavniKarta.Location = new System.Drawing.Point(12, 37);
            this.tcHlavniKarta.Name = "tcHlavniKarta";
            this.tcHlavniKarta.SelectedIndex = 0;
            this.tcHlavniKarta.Size = new System.Drawing.Size(434, 268);
            this.tcHlavniKarta.TabIndex = 3;
            // 
            // tpUkoly
            // 
            this.tpUkoly.BackColor = System.Drawing.Color.White;
            this.tpUkoly.Controls.Add(this.btInfoUkol);
            this.tpUkoly.Controls.Add(this.btOdstranitUkol);
            this.tpUkoly.Controls.Add(this.btUpravitUkol);
            this.tpUkoly.Controls.Add(this.btNovyUkol);
            this.tpUkoly.Controls.Add(this.lbPodrobnostiUkol);
            this.tpUkoly.Controls.Add(this.lbPodrobnostiUkolNazev);
            this.tpUkoly.Controls.Add(this.lbDatumUkoly);
            this.tpUkoly.Controls.Add(this.lbZadneUkoly);
            this.tpUkoly.Controls.Add(this.lvUkoly);
            this.tpUkoly.Location = new System.Drawing.Point(4, 22);
            this.tpUkoly.Name = "tpUkoly";
            this.tpUkoly.Padding = new System.Windows.Forms.Padding(3);
            this.tpUkoly.Size = new System.Drawing.Size(426, 242);
            this.tpUkoly.TabIndex = 0;
            this.tpUkoly.Text = "Úkoly";
            // 
            // btInfoUkol
            // 
            this.btInfoUkol.Location = new System.Drawing.Point(344, 213);
            this.btInfoUkol.Name = "btInfoUkol";
            this.btInfoUkol.Size = new System.Drawing.Size(75, 23);
            this.btInfoUkol.TabIndex = 9;
            this.btInfoUkol.Text = "&Info o úkolu";
            this.btInfoUkol.UseVisualStyleBackColor = true;
            this.btInfoUkol.Click += new System.EventHandler(this.btInfoUkol_Click);
            // 
            // btOdstranitUkol
            // 
            this.btOdstranitUkol.Location = new System.Drawing.Point(255, 213);
            this.btOdstranitUkol.Name = "btOdstranitUkol";
            this.btOdstranitUkol.Size = new System.Drawing.Size(82, 23);
            this.btOdstranitUkol.TabIndex = 8;
            this.btOdstranitUkol.Text = "&Odstranit úkol";
            this.btOdstranitUkol.UseVisualStyleBackColor = true;
            this.btOdstranitUkol.Click += new System.EventHandler(this.btOdstranitUkol_Click);
            // 
            // btUpravitUkol
            // 
            this.btUpravitUkol.Location = new System.Drawing.Point(175, 213);
            this.btUpravitUkol.Name = "btUpravitUkol";
            this.btUpravitUkol.Size = new System.Drawing.Size(74, 23);
            this.btUpravitUkol.TabIndex = 7;
            this.btUpravitUkol.Text = "&Upravit úkol";
            this.btUpravitUkol.UseVisualStyleBackColor = true;
            this.btUpravitUkol.Click += new System.EventHandler(this.btUpravitUkol_Click);
            // 
            // btNovyUkol
            // 
            this.btNovyUkol.Location = new System.Drawing.Point(102, 213);
            this.btNovyUkol.Name = "btNovyUkol";
            this.btNovyUkol.Size = new System.Drawing.Size(67, 23);
            this.btNovyUkol.TabIndex = 5;
            this.btNovyUkol.Text = "&Nový úkol";
            this.btNovyUkol.UseVisualStyleBackColor = true;
            this.btNovyUkol.Click += new System.EventHandler(this.btNovyUkol_Click);
            // 
            // lbPodrobnostiUkol
            // 
            this.lbPodrobnostiUkol.AutoSize = true;
            this.lbPodrobnostiUkol.Location = new System.Drawing.Point(8, 172);
            this.lbPodrobnostiUkol.Name = "lbPodrobnostiUkol";
            this.lbPodrobnostiUkol.Size = new System.Drawing.Size(0, 13);
            this.lbPodrobnostiUkol.TabIndex = 6;
            // 
            // lbPodrobnostiUkolNazev
            // 
            this.lbPodrobnostiUkolNazev.AutoSize = true;
            this.lbPodrobnostiUkolNazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPodrobnostiUkolNazev.Location = new System.Drawing.Point(6, 155);
            this.lbPodrobnostiUkolNazev.Name = "lbPodrobnostiUkolNazev";
            this.lbPodrobnostiUkolNazev.Size = new System.Drawing.Size(182, 13);
            this.lbPodrobnostiUkolNazev.TabIndex = 4;
            this.lbPodrobnostiUkolNazev.Text = "Podrobnosti o vybraném úkolu:";
            // 
            // lbDatumUkoly
            // 
            this.lbDatumUkoly.AutoSize = true;
            this.lbDatumUkoly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDatumUkoly.Location = new System.Drawing.Point(10, 10);
            this.lbDatumUkoly.Name = "lbDatumUkoly";
            this.lbDatumUkoly.Size = new System.Drawing.Size(51, 16);
            this.lbDatumUkoly.TabIndex = 5;
            this.lbDatumUkoly.Text = "label1";
            // 
            // lbZadneUkoly
            // 
            this.lbZadneUkoly.AutoSize = true;
            this.lbZadneUkoly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZadneUkoly.Location = new System.Drawing.Point(62, 91);
            this.lbZadneUkoly.Name = "lbZadneUkoly";
            this.lbZadneUkoly.Size = new System.Drawing.Size(289, 16);
            this.lbZadneUkoly.TabIndex = 4;
            this.lbZadneUkoly.Text = "Na tento den nemáte naplánované žádné úkoly";
            this.lbZadneUkoly.Visible = false;
            // 
            // tpUdalosti
            // 
            this.tpUdalosti.Controls.Add(this.btInfoUdalost);
            this.tpUdalosti.Controls.Add(this.btOdstranitUdalost);
            this.tpUdalosti.Controls.Add(this.btUpravitUdalost);
            this.tpUdalosti.Controls.Add(this.btNovaUdalost);
            this.tpUdalosti.Controls.Add(this.lbUdalostPodrobnosti);
            this.tpUdalosti.Controls.Add(this.lbZadneUdalosti);
            this.tpUdalosti.Controls.Add(this.lvUdalosti);
            this.tpUdalosti.Controls.Add(this.lbUdalostPodrobnostiNazev);
            this.tpUdalosti.Controls.Add(this.lbDatumUdalosti);
            this.tpUdalosti.Location = new System.Drawing.Point(4, 22);
            this.tpUdalosti.Name = "tpUdalosti";
            this.tpUdalosti.Padding = new System.Windows.Forms.Padding(3);
            this.tpUdalosti.Size = new System.Drawing.Size(426, 242);
            this.tpUdalosti.TabIndex = 1;
            this.tpUdalosti.Text = "Události";
            this.tpUdalosti.UseVisualStyleBackColor = true;
            // 
            // btInfoUdalost
            // 
            this.btInfoUdalost.Location = new System.Drawing.Point(338, 213);
            this.btInfoUdalost.Name = "btInfoUdalost";
            this.btInfoUdalost.Size = new System.Drawing.Size(81, 23);
            this.btInfoUdalost.TabIndex = 11;
            this.btInfoUdalost.Text = "&Info o události";
            this.btInfoUdalost.UseVisualStyleBackColor = true;
            this.btInfoUdalost.Click += new System.EventHandler(this.btInfoUdalost_Click);
            // 
            // btOdstranitUdalost
            // 
            this.btOdstranitUdalost.Location = new System.Drawing.Point(237, 213);
            this.btOdstranitUdalost.Name = "btOdstranitUdalost";
            this.btOdstranitUdalost.Size = new System.Drawing.Size(95, 23);
            this.btOdstranitUdalost.TabIndex = 10;
            this.btOdstranitUdalost.Text = "&Odstranit událost";
            this.btOdstranitUdalost.UseVisualStyleBackColor = true;
            this.btOdstranitUdalost.Click += new System.EventHandler(this.btOdstranitUdalost_Click);
            // 
            // btUpravitUdalost
            // 
            this.btUpravitUdalost.Location = new System.Drawing.Point(144, 213);
            this.btUpravitUdalost.Name = "btUpravitUdalost";
            this.btUpravitUdalost.Size = new System.Drawing.Size(90, 23);
            this.btUpravitUdalost.TabIndex = 9;
            this.btUpravitUdalost.Text = "&Upravit událost";
            this.btUpravitUdalost.UseVisualStyleBackColor = true;
            this.btUpravitUdalost.Click += new System.EventHandler(this.btUpravitUdalost_Click);
            // 
            // btNovaUdalost
            // 
            this.btNovaUdalost.Location = new System.Drawing.Point(58, 213);
            this.btNovaUdalost.Name = "btNovaUdalost";
            this.btNovaUdalost.Size = new System.Drawing.Size(80, 23);
            this.btNovaUdalost.TabIndex = 5;
            this.btNovaUdalost.Text = "&Nová událost";
            this.btNovaUdalost.UseVisualStyleBackColor = true;
            this.btNovaUdalost.Click += new System.EventHandler(this.btNovaUdalost_Click);
            // 
            // lbUdalostPodrobnosti
            // 
            this.lbUdalostPodrobnosti.AutoSize = true;
            this.lbUdalostPodrobnosti.Location = new System.Drawing.Point(8, 172);
            this.lbUdalostPodrobnosti.Name = "lbUdalostPodrobnosti";
            this.lbUdalostPodrobnosti.Size = new System.Drawing.Size(0, 13);
            this.lbUdalostPodrobnosti.TabIndex = 8;
            // 
            // lbZadneUdalosti
            // 
            this.lbZadneUdalosti.AutoSize = true;
            this.lbZadneUdalosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZadneUdalosti.Location = new System.Drawing.Point(55, 91);
            this.lbZadneUdalosti.Name = "lbZadneUdalosti";
            this.lbZadneUdalosti.Size = new System.Drawing.Size(304, 16);
            this.lbZadneUdalosti.TabIndex = 6;
            this.lbZadneUdalosti.Text = "Na tento den nemáte naplánované žádné události";
            this.lbZadneUdalosti.Visible = false;
            // 
            // lbUdalostPodrobnostiNazev
            // 
            this.lbUdalostPodrobnostiNazev.AutoSize = true;
            this.lbUdalostPodrobnostiNazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUdalostPodrobnostiNazev.Location = new System.Drawing.Point(6, 155);
            this.lbUdalostPodrobnostiNazev.Name = "lbUdalostPodrobnostiNazev";
            this.lbUdalostPodrobnostiNazev.Size = new System.Drawing.Size(186, 13);
            this.lbUdalostPodrobnostiNazev.TabIndex = 7;
            this.lbUdalostPodrobnostiNazev.Text = "Podrobnosti o vybrané události:";
            // 
            // lbDatumUdalosti
            // 
            this.lbDatumUdalosti.AutoSize = true;
            this.lbDatumUdalosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDatumUdalosti.Location = new System.Drawing.Point(10, 10);
            this.lbDatumUdalosti.Name = "lbDatumUdalosti";
            this.lbDatumUdalosti.Size = new System.Drawing.Size(51, 16);
            this.lbDatumUdalosti.TabIndex = 6;
            this.lbDatumUdalosti.Text = "label1";
            // 
            // lbPrani
            // 
            this.lbPrani.AutoSize = true;
            this.lbPrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPrani.Location = new System.Drawing.Point(292, 30);
            this.lbPrani.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbPrani.Name = "lbPrani";
            this.lbPrani.Size = new System.Drawing.Size(46, 17);
            this.lbPrani.TabIndex = 4;
            this.lbPrani.Text = "label1";
            this.lbPrani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnMenu
            // 
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přehledyToolStripMenuItem,
            this.práceSDatyToolStripMenuItem,
            this.oAplikaciToolStripMenuItem});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(626, 24);
            this.mnMenu.TabIndex = 7;
            this.mnMenu.Text = "menuStrip1";
            // 
            // přehledyToolStripMenuItem
            // 
            this.přehledyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přehledÚkolůAUdálostíToolStripMenuItem,
            this.správceDruhůToolStripMenuItem});
            this.přehledyToolStripMenuItem.Name = "přehledyToolStripMenuItem";
            this.přehledyToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.přehledyToolStripMenuItem.Text = "Přehledy";
            // 
            // přehledÚkolůAUdálostíToolStripMenuItem
            // 
            this.přehledÚkolůAUdálostíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podleDruhuToolStripMenuItem});
            this.přehledÚkolůAUdálostíToolStripMenuItem.Name = "přehledÚkolůAUdálostíToolStripMenuItem";
            this.přehledÚkolůAUdálostíToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.přehledÚkolůAUdálostíToolStripMenuItem.Text = "Přehled úkolů a událostí";
            // 
            // podleDruhuToolStripMenuItem
            // 
            this.podleDruhuToolStripMenuItem.Name = "podleDruhuToolStripMenuItem";
            this.podleDruhuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.podleDruhuToolStripMenuItem.Text = "Podle druhu";
            this.podleDruhuToolStripMenuItem.Click += new System.EventHandler(this.podleDruhuToolStripMenuItem_Click);
            // 
            // správceDruhůToolStripMenuItem
            // 
            this.správceDruhůToolStripMenuItem.Name = "správceDruhůToolStripMenuItem";
            this.správceDruhůToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.správceDruhůToolStripMenuItem.Text = "Správce druhů";
            this.správceDruhůToolStripMenuItem.Click += new System.EventHandler(this.správceDruhůToolStripMenuItem_Click);
            // 
            // práceSDatyToolStripMenuItem
            // 
            this.práceSDatyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importovatXMLToolStripMenuItem,
            this.exportovatXMLToolStripMenuItem});
            this.práceSDatyToolStripMenuItem.Name = "práceSDatyToolStripMenuItem";
            this.práceSDatyToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.práceSDatyToolStripMenuItem.Text = "Práce s daty";
            // 
            // importovatXMLToolStripMenuItem
            // 
            this.importovatXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.úkolyToolStripMenuItem,
            this.událostiToolStripMenuItem});
            this.importovatXMLToolStripMenuItem.Name = "importovatXMLToolStripMenuItem";
            this.importovatXMLToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.importovatXMLToolStripMenuItem.Text = "Importovat XML ";
            // 
            // úkolyToolStripMenuItem
            // 
            this.úkolyToolStripMenuItem.Name = "úkolyToolStripMenuItem";
            this.úkolyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.úkolyToolStripMenuItem.Text = "Úkoly";
            this.úkolyToolStripMenuItem.Click += new System.EventHandler(this.úkolyToolStripMenuItem_Click);
            // 
            // událostiToolStripMenuItem
            // 
            this.událostiToolStripMenuItem.Name = "událostiToolStripMenuItem";
            this.událostiToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.událostiToolStripMenuItem.Text = "Události";
            this.událostiToolStripMenuItem.Click += new System.EventHandler(this.událostiToolStripMenuItem_Click);
            // 
            // exportovatXMLToolStripMenuItem
            // 
            this.exportovatXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.úkolyToolStripMenuItem1,
            this.událostiToolStripMenuItem1});
            this.exportovatXMLToolStripMenuItem.Name = "exportovatXMLToolStripMenuItem";
            this.exportovatXMLToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exportovatXMLToolStripMenuItem.Text = "Exportovat XML";
            // 
            // úkolyToolStripMenuItem1
            // 
            this.úkolyToolStripMenuItem1.Name = "úkolyToolStripMenuItem1";
            this.úkolyToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.úkolyToolStripMenuItem1.Text = "Úkoly";
            this.úkolyToolStripMenuItem1.Click += new System.EventHandler(this.úkolyToolStripMenuItem1_Click);
            // 
            // událostiToolStripMenuItem1
            // 
            this.událostiToolStripMenuItem1.Name = "událostiToolStripMenuItem1";
            this.událostiToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.událostiToolStripMenuItem1.Text = "Události";
            this.událostiToolStripMenuItem1.Click += new System.EventHandler(this.událostiToolStripMenuItem1_Click);
            // 
            // oAplikaciToolStripMenuItem
            // 
            this.oAplikaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentaceToolStripMenuItem});
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            // 
            // dokumentaceToolStripMenuItem
            // 
            this.dokumentaceToolStripMenuItem.Name = "dokumentaceToolStripMenuItem";
            this.dokumentaceToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dokumentaceToolStripMenuItem.Text = "Dokumentace";
            this.dokumentaceToolStripMenuItem.Click += new System.EventHandler(this.dokumentaceToolStripMenuItem_Click);
            // 
            // planovac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 315);
            this.Controls.Add(this.lbPrani);
            this.Controls.Add(this.tcHlavniKarta);
            this.Controls.Add(this.kalendar);
            this.Controls.Add(this.mnMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "planovac";
            this.Text = "Plánovač úkolů a událostí";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.planovac_FormClosed);
            this.Load += new System.EventHandler(this.planovac_Load);
            this.tcHlavniKarta.ResumeLayout(false);
            this.tpUkoly.ResumeLayout(false);
            this.tpUkoly.PerformLayout();
            this.tpUdalosti.ResumeLayout(false);
            this.tpUdalosti.PerformLayout();
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar kalendar;
        private System.Windows.Forms.ListView lvUkoly;
        private System.Windows.Forms.ColumnHeader cas;
        private System.Windows.Forms.ColumnHeader druh;
        private System.Windows.Forms.ColumnHeader nazev;
        private System.Windows.Forms.ListView lvUdalosti;
        private System.Windows.Forms.ColumnHeader druhUdalosti;
        private System.Windows.Forms.ColumnHeader nazevUdalosti;
        private System.Windows.Forms.TabControl tcHlavniKarta;
        private System.Windows.Forms.TabPage tpUkoly;
        private System.Windows.Forms.TabPage tpUdalosti;
        private System.Windows.Forms.Label lbDatumUkoly;
        private System.Windows.Forms.Label lbZadneUkoly;
        private System.Windows.Forms.Label lbDatumUdalosti;
        private System.Windows.Forms.Label lbZadneUdalosti;
        private System.Windows.Forms.Label lbPodrobnostiUkol;
        private System.Windows.Forms.Label lbPodrobnostiUkolNazev;
        private System.Windows.Forms.Label lbUdalostPodrobnosti;
        private System.Windows.Forms.Label lbUdalostPodrobnostiNazev;
        private System.Windows.Forms.Label lbPrani;
        private System.Windows.Forms.Button btNovyUkol;
        private System.Windows.Forms.Button btUpravitUkol;
        private System.Windows.Forms.Button btOdstranitUkol;
        private System.Windows.Forms.Button btNovaUdalost;
        private System.Windows.Forms.Button btOdstranitUdalost;
        private System.Windows.Forms.Button btUpravitUdalost;
        private System.Windows.Forms.MenuStrip mnMenu;
        private System.Windows.Forms.ToolStripMenuItem přehledyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přehledÚkolůAUdálostíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podleDruhuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem správceDruhůToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem práceSDatyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importovatXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportovatXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem úkolyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem událostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem úkolyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem událostiToolStripMenuItem1;
        private System.Windows.Forms.Button btInfoUkol;
        private System.Windows.Forms.Button btInfoUdalost;
    }
}

