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

namespace planovac_2_0
{
    public partial class frmDruhy : Form
    {
        List<Ukol> seznamUkolu = new List<Ukol>();
        List<Udalost> seznamUdalosti = new List<Udalost>();
        List<string> seznamDruhu = new List<string>();

        public frmDruhy()
        {
            InitializeComponent();
            seznamUkolu = Metody.LoadUkolXml("../../Data/Ukoly.xml");
            seznamUdalosti = Metody.LoadUdalostXml("../../Data/Udalosti.xml");
        }

        //Výběr indexu z listBoxu
        public int getIndex()
        {
            return lboDruhy.SelectedIndex;
        }

        //Vložení seznamu druhů do listBoxu
        public void VlozeniDoListBoxu(List<string> seznam)
        {
            lboDruhy.DataSource = seznam;
        }

        //Kontrola zda existuje v seznamech nějaká položka s druhem
        public bool kontrolaZdaJeDruhPrazdny(string druh)
        {
            for(int i = 0; i < seznamUkolu.Count; i++)
            {
                if (seznamUkolu[i].druh.Equals(druh))
                {
                    return false;
                }
            }
            for (int i = 0; i < seznamUdalosti.Count; i++)
            {
                if (seznamUdalosti[i].druh.Equals(druh))
                {
                    return false;
                }
            }
            return true;
        }

        //Zabezpečení, aby nešel smazat druh, který obsahuje položky
        private void lboDruhy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kontrolaZdaJeDruhPrazdny((string)lboDruhy.SelectedValue))
            {
                btVymazatDruh.Enabled = true;
            }
            else
            {
                btVymazatDruh.Enabled = false;
            }
        }
    }
}
