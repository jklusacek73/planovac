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
    public partial class frmUpravaAPridavani : Form
    {
        public frmUpravaAPridavani()
        {
            InitializeComponent();
        }

        //---------------
        //Základní funkce
        //---------------

        public string Nazev
        {
            get { return tbNazev.Text; }
            set { tbNazev.Text = value; }
        }

        public string Druh
        {
            get { return cbDruh.Text; }
            set { cbDruh.SelectedItem = value; }
        }

        public string NovyDruh
        {
            get { return tbJinyDruh.Text; }
        }

        public DateTime Datum
        {
            get { return dtpDatum.Value; }
            set { dtpDatum.Value = value; }
        }

        public int Hodina
        {
            get { return (int)nudHodina.Value; }
            set { nudHodina.Value = value; }
        }

        public int Minuta
        {
            get { return (int)nudMinuta.Value; }
            set { nudMinuta.Value = value; }
        }

        public string Podrobnosti
        {
            get { return rtbPodrobnosti.Text; }
            set { rtbPodrobnosti.Text = value; }
        }

        //-------------------------------------
        //Metody pro vkládání a čtení informací
        //-------------------------------------

        //Funkce pro nastavení formuláře, jestli je nebo není úkol (true = úkol, false = údalost)
        public void isUkol(bool promenna)
        {
            if (promenna == true)
            {
                gbNazev.Text += " úkolu";
                gbDruh.Text += " úkolu";
                gbDatumCas.Text += " a čas úkolu";
                gbPodrobnosti.Text += " k úkolu";
            }
            else
            {
                gbNazev.Text += " události";
                gbDruh.Text += " události";
                gbDatumCas.Text += " události";
                gbPodrobnosti.Text += " k události";
                lbMinuta.Visible = false;
                lbHodina.Visible = false;
                nudHodina.Visible = false;
                nudMinuta.Visible = false;
            }
        }

        //Vložení druhů do comboBoxu
        public void vlozeniDoComboBox(List<string> druhy)
        {
            cbDruh.DataSource = new BindingSource(druhy, null);
        }

        //Získání názvu druhu (při novém i upravovaném úkolu a události)
        public string urceniDruhu()
        {
            if (rbBezUrceniDruhu.Checked == true)
            {
                return "";
            }
            else if(rbUrcitDruh.Checked == true)
            {
                return Druh;
            }
            else
            {
                return ValidaceDat.kontrolaNovehoDruhu(NovyDruh);
            }
        }

        //Vložení správného druhu do formuláře při aktualizace úkolu a události
        public void jakyDruh(string nazevDruhu)
        {
            tbJinyDruh.Enabled = false;
            if (nazevDruhu.Equals(""))
            {
                rbBezUrceniDruhu.Checked = true;
            }
            else
            {
                rbUrcitDruh.Checked = true;
                Druh = nazevDruhu;
            }
        }

        //Nastavení data pro úkoly a udáosti (true = úkol, false = událost)
        public void novyUkolUdalost(bool ukol, DateTime datum)
        {
            rbBezUrceniDruhu.Checked = true;
            dtpDatum.Value = datum;
            if(ukol == true)
            {
                DateTime dt = DateTime.Now;
                Hodina = dt.Hour;
                Minuta = dt.Minute;
            }
        }

        //-------------------------------------
        //Funkce pro správnou činnost formuláře
        //-------------------------------------

        private void rbBezUrceniDruhu_CheckedChanged(object sender, EventArgs e)
        {
            cbDruh.Enabled = false;
            tbJinyDruh.Enabled = false;
        }

        private void rbUrcitDruh_CheckedChanged(object sender, EventArgs e)
        {
            tbJinyDruh.Enabled = false;
            cbDruh.Enabled = true;
        }

        private void rbJinyDruh_CheckedChanged(object sender, EventArgs e)
        {
            cbDruh.Enabled = false;
            tbJinyDruh.Enabled = true;
        }
    }

    //Vlastní komponenta pro zadávání času tak, aby se zobrazovaly dvě číslice
    class CustomNumericUpDown : NumericUpDown
    {
        protected override void OnTextBoxTextChanged(object source, EventArgs e)
        {
            TextBox tb = source as TextBox;
            int val = 0;
            if (int.TryParse(tb.Text, out val))
            {
                if (val < 10)
                {
                    tb.Text = "0" + val.ToString();
                }
            }
            else
            {
                base.OnTextBoxTextChanged(source, e);
            }
        }
    }
}
