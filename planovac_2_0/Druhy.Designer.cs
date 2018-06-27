namespace planovac_2_0
{
    partial class frmDruhy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDruhy));
            this.lboDruhy = new System.Windows.Forms.ListBox();
            this.btVymazatDruh = new System.Windows.Forms.Button();
            this.btKonec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboDruhy
            // 
            this.lboDruhy.FormattingEnabled = true;
            this.lboDruhy.Location = new System.Drawing.Point(90, 12);
            this.lboDruhy.Name = "lboDruhy";
            this.lboDruhy.Size = new System.Drawing.Size(120, 199);
            this.lboDruhy.TabIndex = 0;
            this.lboDruhy.SelectedIndexChanged += new System.EventHandler(this.lboDruhy_SelectedIndexChanged);
            // 
            // btVymazatDruh
            // 
            this.btVymazatDruh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btVymazatDruh.Enabled = false;
            this.btVymazatDruh.Location = new System.Drawing.Point(67, 217);
            this.btVymazatDruh.Name = "btVymazatDruh";
            this.btVymazatDruh.Size = new System.Drawing.Size(80, 23);
            this.btVymazatDruh.TabIndex = 1;
            this.btVymazatDruh.Text = "&Smazat druh";
            this.btVymazatDruh.UseVisualStyleBackColor = true;
            // 
            // btKonec
            // 
            this.btKonec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btKonec.Location = new System.Drawing.Point(153, 217);
            this.btKonec.Name = "btKonec";
            this.btKonec.Size = new System.Drawing.Size(80, 23);
            this.btKonec.TabIndex = 2;
            this.btKonec.Text = "&Konec";
            this.btKonec.UseVisualStyleBackColor = true;
            // 
            // frmDruhy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btKonec;
            this.ClientSize = new System.Drawing.Size(295, 260);
            this.Controls.Add(this.btKonec);
            this.Controls.Add(this.btVymazatDruh);
            this.Controls.Add(this.lboDruhy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDruhy";
            this.Text = "Správce druhů";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboDruhy;
        private System.Windows.Forms.Button btVymazatDruh;
        private System.Windows.Forms.Button btKonec;
    }
}