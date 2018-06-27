using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace planovac_2_0
{
    public partial class planovac : Form
    {
        //Seznam pro ukládání úkolů
        List<Ukol> seznamUkolu = Metody.LoadUkolXml("../../Data/Ukoly.xml");
        //Seznam pro ukládání událostí
        List<Udalost> seznamUdalosti = Metody.LoadUdalostXml("../../Data/Udalosti.xml");
        //Seznam pro ukládání druhů
        List<string> seznamDruhu = new List<string>();
        public planovac()
        {
            InitializeComponent();
            lvUkoly.FullRowSelect = true;
            lvUdalosti.FullRowSelect = true;
            string[] druhy = File.ReadAllLines("../../Data/soubor.txt");
            seznamDruhu = druhy.ToList();
            vlozeniDatDoListView();
        }

        //----------------------------
        //Funkce pro činnost formuláře
        //----------------------------

        //Změna data v kalendáři
        private void kalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            vlozeniDatDoListView();
        }

        //Načtení plánovače, do kterého se vloží data a zobrazí se přání
        private void planovac_Load(object sender, EventArgs e)
        {
            vlozeniDatDoListView();
            DateTime now = DateTime.Now;
            lbPrani.Text = Metody.denniPrani(now.Hour) + ". Dnes je " + now.ToLongDateString() + ".";
        }

        //Fukce při ukončení činnosti a plánovači
        private void planovac_FormClosed(object sender, FormClosedEventArgs e)
        {
            string[] druhy = seznamDruhu.ToArray();
            File.WriteAllLines("../../Data/soubor.txt", druhy);
            Metody.SaveUkolListXml("../../Data/Ukoly.xml", seznamUkolu);
            Metody.SaveUdalostListXml("../../Data/Udalosti.xml", seznamUdalosti);
        }

        //Ošetření při změně výběru v ListView s událostmi
        private void lvUdalosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cislo = vybratIndex(lvUdalosti);
            if (cislo == -1) 
            {
                btUpravitUdalost.Enabled = false;
                btOdstranitUdalost.Enabled = false;
                btInfoUdalost.Enabled = false;
                return;
            }
            else if (seznamUdalosti[cislo].popis.Equals(""))
            {
                btUpravitUdalost.Enabled = true;
                btOdstranitUdalost.Enabled = true;
                btInfoUdalost.Enabled = true;
                lbUdalostPodrobnosti.Text = Properties.Resources.PODROBNOSTI_UDALOST_NO;
            }
            else
            {
                btUpravitUdalost.Enabled = true;
                btOdstranitUdalost.Enabled = true;
                btInfoUdalost.Enabled = true;
                lbUdalostPodrobnosti.Text = seznamUdalosti[cislo].popis;
            }
        }

        //Ošetření při změně výběru v ListView s úkoly
        private void lvUkoly_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cislo = vybratIndex(lvUkoly);
            if (cislo == -1)
            {
                btUpravitUkol.Enabled = false;
                btOdstranitUkol.Enabled = false;
                btInfoUkol.Enabled = false;
                return;
            }
            else if (seznamUkolu[cislo].popis.Equals(""))
            {
                btUpravitUkol.Enabled = true;
                btOdstranitUkol.Enabled = true;
                btInfoUkol.Enabled = true;
                lbPodrobnostiUkol.Text = Properties.Resources.PODROBNOSTI_UKOL_NO;
            }
            else
            {
                btUpravitUkol.Enabled = true;
                btOdstranitUkol.Enabled = true;
                btInfoUkol.Enabled = true;
                lbPodrobnostiUkol.Text = seznamUkolu[cislo].popis;
            }
        }

        //-----------------------
        //Fukce pro práci s úkoly
        //-----------------------

        //Přidání nového úkolu
        private void btNovyUkol_Click(object sender, EventArgs e)
        {
            frmUpravaAPridavani novyUkol = new frmUpravaAPridavani();
            novyUkol.Text = Properties.Resources.NADPIS_PRIDANI_UKOL;
            novyUkol.isUkol(true);
            novyUkol.novyUkolUdalost(true, kalendar.SelectionRange.Start);
            novyUkol.vlozeniDoComboBox(seznamDruhu);
            DialogResult rslt = novyUkol.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                try
                {
                    string nazev = ValidaceDat.kontrolaNazvu(novyUkol.Nazev);
                    string druh = novyUkol.urceniDruhu();
                    if ((seznamDruhu.Contains(druh) == false) && (!druh.Equals("")))
                    {
                        seznamDruhu.Add(druh);
                    }
                    Ukol u = new Ukol(nazev, druh, novyUkol.Podrobnosti, novyUkol.Datum.Day, novyUkol.Datum.Month, novyUkol.Datum.Year, novyUkol.Hodina, novyUkol.Minuta);
                    seznamUkolu.Add(u);
                    seznamUkolu = Metody.razeniUkolu(seznamUkolu);
                    vlozeniDatDoListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.NADPIS_CHYBA_PRIDAVANI_UKOLU, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Úprava úkolu
        private void btUpravitUkol_Click(object sender, EventArgs e)
        {
            int cislo = vybratIndex(lvUkoly);
            if (cislo != -1)
            {
                frmUpravaAPridavani upravitUkol = new frmUpravaAPridavani();
                upravitUkol.Text = Properties.Resources.NADPIS_UPRAVA_UKOL;
                upravitUkol.isUkol(true);
                upravitUkol.vlozeniDoComboBox(seznamDruhu);
                upravitUkol.Nazev = seznamUkolu[cislo].nazev;
                upravitUkol.Druh = seznamUkolu[cislo].druh;
                upravitUkol.Datum = seznamUkolu[cislo].datum;
                upravitUkol.Hodina = seznamUkolu[cislo].hodina;
                upravitUkol.Minuta = seznamUkolu[cislo].minuta;
                upravitUkol.Podrobnosti = seznamUkolu[cislo].popis;
                upravitUkol.jakyDruh(seznamUkolu[cislo].druh);
                DialogResult rslt = upravitUkol.ShowDialog();
                if (rslt == DialogResult.OK)
                {
                    try
                    {
                        string nazev = ValidaceDat.kontrolaNazvu(upravitUkol.Nazev);
                        string druh = upravitUkol.urceniDruhu();
                        if ((seznamDruhu.Contains(druh) == false) && (!druh.Equals("")))
                        {
                            seznamDruhu.Add(druh);
                        }
                        Ukol u = new Ukol(nazev, druh, upravitUkol.Podrobnosti, upravitUkol.Datum.Day, upravitUkol.Datum.Month, upravitUkol.Datum.Year, upravitUkol.Hodina, upravitUkol.Minuta);
                        seznamUkolu.RemoveAt(cislo);
                        seznamUkolu.Add(u);
                        seznamUkolu = Metody.razeniUkolu(seznamUkolu);
                        vlozeniDatDoListView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Properties.Resources.NADPIS_CHYBA_UPRAVA_UKOLU, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Odstranění úkolu
        private void btOdstranitUkol_Click(object sender, EventArgs e)
        {
            int cislo = vybratIndex(lvUkoly);
            seznamUkolu.RemoveAt(cislo);
            vlozeniDatDoListView();
        }

        //Zobrazení informací o úkolu
        private void btInfoUkol_Click(object sender, EventArgs e)
        {
            int cislo = vybratIndex(lvUkoly);
            MessageBox.Show(seznamUkolu[cislo].toString(), Properties.Resources.UKOL_INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------
        //Fukce pro práci s událostmi
        //---------------------------

        //Přidíní nové události
        private void btNovaUdalost_Click(object sender, EventArgs e)
        {
            frmUpravaAPridavani novaUdalost = new frmUpravaAPridavani();
            novaUdalost.Text = Properties.Resources.NADPIS_PRIDANI_UDALOST;
            novaUdalost.isUkol(false);
            novaUdalost.novyUkolUdalost(false, kalendar.SelectionRange.Start);
            novaUdalost.vlozeniDoComboBox(seznamDruhu);
            DialogResult rslt = novaUdalost.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                try
                {
                    string nazev = ValidaceDat.kontrolaNazvu(novaUdalost.Nazev);
                    string druh = novaUdalost.urceniDruhu();
                    if ((seznamDruhu.Contains(druh) == false) && (!druh.Equals("")))
                    {
                        seznamDruhu.Add(druh);
                    }
                    Udalost u = new Udalost(nazev, druh, novaUdalost.Podrobnosti, novaUdalost.Datum.Day, novaUdalost.Datum.Month, novaUdalost.Datum.Year);
                    seznamUdalosti.Add(u);
                    seznamUdalosti = Metody.razeniUdalosti(seznamUdalosti);
                    vlozeniDatDoListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.NADPIS_CHYBA_PRIDAVANI_UDALOSTI, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Úprava vybrané události
        private void btUpravitUdalost_Click(object sender, EventArgs e)
        {
            int cislo = vybratIndex(lvUdalosti);
            if (cislo != -1)
            {
                frmUpravaAPridavani upravitUdalost = new frmUpravaAPridavani();
                upravitUdalost.Text = Properties.Resources.NADPIS_UPRAVA_UDALOST;
                upravitUdalost.isUkol(false);
                upravitUdalost.vlozeniDoComboBox(seznamDruhu);
                upravitUdalost.Nazev = seznamUdalosti[cislo].nazev;
                upravitUdalost.Druh = seznamUdalosti[cislo].druh;
                upravitUdalost.Datum = seznamUdalosti[cislo].datum;
                upravitUdalost.Podrobnosti = seznamUdalosti[cislo].popis;
                upravitUdalost.jakyDruh(seznamUdalosti[cislo].druh);
                DialogResult rslt = upravitUdalost.ShowDialog();
                if (rslt == DialogResult.OK)
                {
                    try
                    {
                        string nazev = ValidaceDat.kontrolaNazvu(upravitUdalost.Nazev);
                        string druh = upravitUdalost.urceniDruhu();
                        if ((seznamDruhu.Contains(druh) == false) && (!druh.Equals("")))
                        {
                            seznamDruhu.Add(druh);
                        }
                        Udalost u = new Udalost(nazev, druh, upravitUdalost.Podrobnosti, upravitUdalost.Datum.Day, upravitUdalost.Datum.Month, upravitUdalost.Datum.Year);
                        seznamUdalosti.RemoveAt(cislo);
                        seznamUdalosti.Add(u);
                        seznamUdalosti = Metody.razeniUdalosti(seznamUdalosti);
                        vlozeniDatDoListView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Properties.Resources.NADPIS_CHYBA_UPRAVA_UDALOSTI, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Odstranění vybrané události
        private void btOdstranitUdalost_Click(object sender, EventArgs e)
        {
            int cislo = vybratIndex(lvUdalosti);
            seznamUdalosti.RemoveAt(cislo);
            vlozeniDatDoListView();
        }

        //Zobrazení inforací o události
        private void btInfoUdalost_Click(object sender, EventArgs e)
        {
            int cislo = vybratIndex(lvUdalosti);
            MessageBox.Show(seznamUdalosti[cislo].toString(), Properties.Resources.UDALOST_INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //------------------------------
        //Fukce pro činnost horního menu
        //------------------------------

        //Zobrazení přehledu úkolů a událostí
        private void podleDruhuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metody.SaveUkolListXml("../../Data/Ukoly.xml", seznamUkolu);
            Metody.SaveUdalostListXml("../../Data/Udalosti.xml", seznamUdalosti);
            frmTrideni trideni = new frmTrideni();
            trideni.vlozeniDoComboBox(seznamDruhu);
            trideni.ShowDialog();
        }

        //Zobrazení, nastavení a výsledek správce druhů
        private void správceDruhůToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metody.SaveUkolListXml("../../Data/Ukoly.xml", seznamUkolu);
            Metody.SaveUdalostListXml("../../Data/Udalosti.xml", seznamUdalosti);
            frmDruhy druhy = new frmDruhy();
            druhy.VlozeniDoListBoxu(seznamDruhu);
            DialogResult rslt = druhy.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                seznamDruhu.RemoveAt(druhy.getIndex());
            }
        }

        //Importování úkolů do seznamu úkolů
        private void úkolyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML soubory (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = ofd.FileName;
                    seznamUkolu = Metody.LoadUkolXml(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.CHYBA_PRI_NACITANI, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            vlozeniDatDoListView();
        }

        //Importování událostí do seznamu událostí
        private void událostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML soubory (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = ofd.FileName;
                    seznamUdalosti = Metody.LoadUdalostXml(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.CHYBA_PRI_NACITANI, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            vlozeniDatDoListView();
        }

        //Exportování úkolu do xml souboru
        private void úkolyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML soubory (*.xml)|*.xml";
            sfd.FilterIndex = 0;
            sfd.DefaultExt = "xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Metody.SaveUkolListXml(sfd.FileName, seznamUkolu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.CHYBA_PRI_UKLADANI, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Exportování událostí do xml souboru
        private void událostiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML soubory (*.xml)|*.xml";
            sfd.FilterIndex = 0;
            sfd.DefaultExt = "xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Metody.SaveUdalostListXml(sfd.FileName, seznamUdalosti);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.CHYBA_PRI_UKLADANI, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Otevření dokumentace
        private void dokumentaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("dokumentace.pdf");
        }

        //----------------------------------------
        //Další metody důležité pro chod formuláře
        //----------------------------------------

        //Metoda ošetřující změnu data v kalendáři
        public void vlozeniDatDoListView()
        {
            deleteItemsFromListView(lvUkoly);
            deleteItemsFromListView(lvUdalosti);
            DateTime vybraneDatum = kalendar.SelectionRange.Start;
            lbDatumUkoly.Text = "Úkoly naplánované na " + vybraneDatum.ToLongDateString();
            if (seznamUkolu.Count > 0)
            {
                for (int i = 0; i < seznamUkolu.Count; i++)
                {
                    if (DateTime.Compare(vybraneDatum, seznamUkolu[i].datum) == 0)
                    {
                        ListViewItem lvi = new ListViewItem(seznamUkolu[i].getCas());
                        lvi.SubItems.Add(seznamUkolu[i].druh);
                        lvi.SubItems.Add(seznamUkolu[i].nazev);
                        lvi.ImageIndex = i;
                        lvUkoly.Items.Add(lvi);
                    }
                    else if (DateTime.Compare(vybraneDatum, seznamUkolu[i].datum) < 0)
                    {
                        break;
                    }
                }
            }
            btUpravitUkol.Enabled = false;
            btOdstranitUkol.Enabled = false;
            btInfoUkol.Enabled = false;
            lbPodrobnostiUkol.Text = "";
            lbDatumUdalosti.Text = "Události naplánované na " + vybraneDatum.ToLongDateString();
            if (seznamUdalosti.Count > 0)
            {
                for (int i = 0; i < seznamUdalosti.Count; i++)
                {
                    if (DateTime.Compare(vybraneDatum, seznamUdalosti[i].datum) == 0)
                    {
                        ListViewItem lvi = new ListViewItem(seznamUdalosti[i].druh);
                        lvi.SubItems.Add(seznamUdalosti[i].nazev);
                        lvi.ImageIndex = i;
                        lvUdalosti.Items.Add(lvi);
                    }
                    else if (DateTime.Compare(vybraneDatum, seznamUdalosti[i].datum) < 0)
                    {
                        break;
                    }
                }
            }
            btUpravitUdalost.Enabled = false;
            btOdstranitUdalost.Enabled = false;
            btInfoUdalost.Enabled = false;
            lbUdalostPodrobnosti.Text = "";
            if (lvUkoly.Items.Count == 0)
            {
                lbZadneUkoly.Visible = true;
                lvUkoly.Visible = false;
                lbPodrobnostiUkolNazev.Visible = false;
                lbPodrobnostiUkol.Visible = false;
            }
            else
            {
                lbZadneUkoly.Visible = false;
                lvUkoly.Visible = true;
                lbPodrobnostiUkolNazev.Visible = true;
                lbPodrobnostiUkol.Visible = true;
            }
            if (lvUdalosti.Items.Count == 0)
            {
                lbZadneUdalosti.Visible = true;
                lvUdalosti.Visible = false;
                lbUdalostPodrobnostiNazev.Visible = false;
                lbUdalostPodrobnosti.Visible = false;
            }
            else
            {
                lbZadneUdalosti.Visible = false;
                lvUdalosti.Visible = true;
                lbUdalostPodrobnostiNazev.Visible = true;
                lbUdalostPodrobnosti.Visible = true;
            }
        }

        //Odstranění položek z ListView (používáno například pči změně data
        public static void deleteItemsFromListView(ListView lv)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].Remove();
                i--;
            }
        }

        //Porovnání zda druh existuje (používáno při zadávání jiného druhu)
        public void kontrolaZdaDruhNeniZadan(List<string> druhy, string novyDruh)
        {
            if (!druhy.Contains(novyDruh))
            {
                druhy.Add(novyDruh);
            }
        }

        //Výběr indexu z ListView tak, aby se dal použít v seznamech
        public static int vybratIndex(ListView list)
        {
            if (list.SelectedIndices.Count <= 0)
            {
                return -1;
            }
            int index = list.SelectedIndices[0];
            int cislo = -1;
            if (index >= 0)
            {
                ListViewItem lvi = list.Items[index];
                cislo = lvi.ImageIndex;
            }
            return cislo;
        }
    }
}
