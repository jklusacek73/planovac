using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace planovac_2_0
{
    class Metody
    {
        //Metoda pro přání uživateli
        public static string denniPrani(int hodina)
        {
            if ((hodina >= 4) && (hodina < 9))
            {
                return "Dobré ráno";
            }
            else if ((hodina >= 9) && (hodina < 12))
            {
                return "Dobré dopoledne";
            }
            else if ((hodina >= 12) && (hodina < 18))
            {
                return "Dobré odpoledne";
            }
            else if ((hodina >= 18) && (hodina < 23))
            {
                return "Dobrý večer";
            }
            else
            {
                return "Dobrou noc";
            }
        }

        //Metoda pro řazení úkolů podle data vzestupně
        public static List<Ukol> razeniUkolu(List<Ukol> neserazeno)
        {
            neserazeno.Sort((a, b) => DateTime.Compare(a.datum, b.datum));
            return neserazeno;
        }

        //Metoda pro řazení událostí podle data vzestupně
        public static List<Udalost> razeniUdalosti(List<Udalost> neserazeno)
        {
            neserazeno.Sort((a, b) => DateTime.Compare(a.datum, b.datum));
            return neserazeno;
        }

        //Vložení hodnot ze souboru xml do seznamu úkolů
        public static List<Ukol> LoadUkolXml(string fileName)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
                XmlSerializer xs = new XmlSerializer(typeof(List<Ukol>));
                return (List<Ukol>)xs.Deserialize(sr);
            }
            catch (Exception) { throw; }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        //Vložení hodnot ze souboru xml do seznamu událostí
        public static List<Udalost> LoadUdalostXml(string fileName)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
                XmlSerializer xs = new XmlSerializer(typeof(List<Udalost>));
                return (List<Udalost>)xs.Deserialize(sr);
            }
            catch (Exception) { throw; }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        //Uložení seznamu úkolů do xml souboru
        public static void SaveUkolListXml(string fileName, List<Ukol> l)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fileName, false);
                XmlSerializer xs = new XmlSerializer(typeof(List<Ukol>));
                xs.Serialize(sw, l);
            }
            catch (Exception) { throw; }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }

        //Uložení seznamu událostí do xml souboru
        public static void SaveUdalostListXml(string fileName, List<Udalost> l)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fileName, false);
                XmlSerializer xs = new XmlSerializer(typeof(List<Udalost>));
                xs.Serialize(sw, l);
            }
            catch (Exception) { throw; }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
    }

    class ValidaceDat
    {
        //Kontrola zda je název úkolu nebo údálosti neprázdný
        public static string kontrolaNazvu(string nazev)
        {
            if ((nazev.Length > 0) && (nazev.Length < 40))
            {
                return nazev;
            }
            else
            {
                throw new System.Exception(Properties.Resources.CHYBA_NAZEV);
            }
        }

        //Kontrola zda je název nového druhu neprázdný
        public static string kontrolaNovehoDruhu(string druh)
        {
            if ((druh.Length > 0) && (druh.Length < 20))
            {
                return druh;
            }
            else
            {
                throw new System.Exception(Properties.Resources.CHYBA_DRUH);
            }
        }
    }
}
