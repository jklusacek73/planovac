using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planovac_2_0
{
    public partial class frmTrideni : Form
    {
        //Vložení dat pro správnou činnost formuláře
        List<Ukol> seznamUkolu = Metody.LoadUkolXml("../../Data/Ukoly.xml");
        List<Udalost> seznamUdalosti = Metody.LoadUdalostXml("../../Data/Udalosti.xml");
        public frmTrideni()
        {
            InitializeComponent();
            lvPrehledUkolu.FullRowSelect = true;
            lvPrehledUdalosti.FullRowSelect = true;
        }

        //---------------
        //Základní funkce
        //---------------

        public string Druh
        {
            get { return cbDruhy.Text; }
            set { cbDruhy.SelectedItem = value; }
        }

        //----------------------------------------------
        //Metody, které využíváme při činnosti formuláře 
        //----------------------------------------------

        //Vložení druhů do comboBoxu
        public void vlozeniDoComboBox(List<string> druhy)
        {
            cbDruhy.DataSource = new BindingSource(druhy, null);
        }

        //Vložení úkolů bez třídění při zatrženém rbNetridit
        public void VlozitUkolyNetridene(List<Ukol> seznam)
        {
            planovac.deleteItemsFromListView(lvPrehledUkolu);
            if (seznam.Count > 0)
            {
                lvPrehledUkolu.Visible = true;
                lbZadneUkoly.Visible = false;
                for (int i = 0; i < seznam.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(seznam[i].getDatum());
                    lvi.SubItems.Add(seznam[i].getCas());
                    lvi.SubItems.Add(seznam[i].druh);
                    lvi.SubItems.Add(seznam[i].nazev);
                    lvi.ImageIndex = i;
                    lvPrehledUkolu.Items.Add(lvi);
                }
            }
            else
            {
                lvPrehledUkolu.Visible = false;
                lbZadneUkoly.Visible = true;
            }
        }

        //Vložení událostí bez třídění při zatrženém rbNetridit
        public void VlozitUdalostiNetridene(List<Udalost> seznam)
        {
            planovac.deleteItemsFromListView(lvPrehledUdalosti);
            if (seznam.Count > 0)
            {
                lvPrehledUdalosti.Visible = true;
                lbZadneUdalosti.Visible = false;
                for (int i = 0; i < seznam.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(seznam[i].getDatum());
                    lvi.SubItems.Add(seznam[i].druh);
                    lvi.SubItems.Add(seznam[i].nazev);
                    lvi.ImageIndex = i;
                    lvPrehledUdalosti.Items.Add(lvi);
                }
            }
            else
            {
                lvPrehledUdalosti.Visible = false;
                lbZadneUdalosti.Visible = true;
            }
        }

        //Vložení úkolů s tříděním podle druhů
        public void VlozitUkolyDruh(List<Ukol> seznam, string druh)
        {
            planovac.deleteItemsFromListView(lvPrehledUkolu);
            if (seznam.Count > 0)
            {
                for (int i = 0; i < seznam.Count; i++)
                {
                    if (seznam[i].druh.Equals(druh))
                    {
                        ListViewItem lvi = new ListViewItem(seznam[i].getDatum());
                        lvi.SubItems.Add(seznam[i].getCas());
                        lvi.SubItems.Add(seznam[i].druh);
                        lvi.SubItems.Add(seznam[i].nazev);
                        lvi.ImageIndex = i;
                        lvPrehledUkolu.Items.Add(lvi);
                    }
                }
            }
            if(lvPrehledUkolu.Items.Count == 0)
            {
                lvPrehledUkolu.Visible = false;
                lbZadneUkoly.Visible = true;
            }
            else
            {
                lvPrehledUkolu.Visible = true;
                lbZadneUkoly.Visible = false;
            }
        }

        //Vložení událostí s tříděním podle druhů
        public void VlozitUdalostiDruh(List<Udalost> seznam, string druh)
        {
            planovac.deleteItemsFromListView(lvPrehledUdalosti);
            if (seznam.Count > 0)
            {
                for (int i = 0; i < seznam.Count; i++)
                {
                    if (seznam[i].druh.Equals(druh))
                    {
                        ListViewItem lvi = new ListViewItem(seznam[i].getDatum());
                        lvi.SubItems.Add(seznam[i].druh);
                        lvi.SubItems.Add(seznam[i].nazev);
                        lvi.ImageIndex = i;
                        lvPrehledUdalosti.Items.Add(lvi);
                    }
                }
            }
            if(lvPrehledUdalosti.Items.Count == 0)
            {
                lvPrehledUdalosti.Visible = false;
                lbZadneUdalosti.Visible = true;
            }
            else
            {
                lvPrehledUdalosti.Visible = true;
                lbZadneUdalosti.Visible = false;
            }
        }

        //------------------------
        //Fukce pro ovládací prvky
        //------------------------

        //Netříděné úkoly a události
        private void rbNetridit_CheckedChanged(object sender, EventArgs e)
        {
            cbDruhy.Enabled = false;
            VlozitUkolyNetridene(seznamUkolu);
            VlozitUdalostiNetridene(seznamUdalosti);
        }

        //Tříděné úkoly a události s prázdnou hodnotou druhu
        private void rbPrazdneDruhy_CheckedChanged(object sender, EventArgs e)
        {
            cbDruhy.Enabled = false;
            VlozitUkolyDruh(seznamUkolu, "");
            VlozitUdalostiDruh(seznamUdalosti, "");
        }

        //Tříděné úkoly a události se zadanou hodnotou druhu
        private void rbTridit_CheckedChanged(object sender, EventArgs e)
        {
            cbDruhy.Enabled = true;
            VlozitUkolyDruh(seznamUkolu, Druh);
            VlozitUdalostiDruh(seznamUdalosti, Druh);
        }

        //Změna hodnoty v comboBoxu
        private void cbDruhy_SelectedIndexChanged(object sender, EventArgs e)
        {
            VlozitUkolyDruh(seznamUkolu, Druh);
            VlozitUdalostiDruh(seznamUdalosti, Druh);
        }
    }
}
