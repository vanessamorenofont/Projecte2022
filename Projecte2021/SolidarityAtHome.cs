using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Projecte2021
{
    public partial class SolidarityAtHome : Form
    {
        private List<string> ltOptions;
        private List<string> ltRefugees;
        private List<string> ltFoods;
        private Dictionary<string, FoodDelivered> dtFoodsDelivered;
        private Dictionary<string, Host> dtHosts;

        public SolidarityAtHome()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void butObrirFitxer_Click(object sender, EventArgs e)
        {
            string strFitxer;
            strFitxer = texFitxer.Text;

            if (File.Exists(strFitxer))
            {
                ltOptions = XMLOperations.GetOptions(strFitxer);

                if (ltOptions.Count > 0)
                {
                    ltFoods = XMLOperations.GetDades(strFitxer, "Foods", "DescFood");
                    ltRefugees = XMLOperations.GetDades(strFitxer, "Refugees", "FullName");
                    dtFoodsDelivered = XMLOperations.GetDeliveredFood(strFitxer);
                    dtHosts = XMLOperations.GetHosts(strFitxer);

                    cmbOpcions.DataSource = ltOptions.ToArray();
                    labErrors.Text = "S'han obtingut dades del fitxer.";
                }
                else
                {
                    cmbOpcions.DataSource = ltOptions.ToArray();
                    labErrors.Text = "No s'han obtingut dades de l'arxiu";
                }
                cmbOpcions.ResetText();
                cmbSecundari.ResetText();
            }
            else
            {
                labErrors.Text = "No s'ha pogut obrir l'arxiu.";
                texFitxer.Text = "";
            }
        }

        private void cmbOpcions_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> ltDades;

            switch (cmbOpcions.SelectedItem)
            {
                case "Hosts":
                    ltDades = dtHosts.Keys.ToList();
                    break;
                case "Refugees":
                    ltDades = ltRefugees;
                    break;
                case "Foods":
                    ltDades = ltFoods;
                    break;
                case "FoodsDelivered":
                    ltDades = dtFoodsDelivered.Keys.ToList();
                    break;
                default:
                    ltDades = new List<string>();
                    break;
            }
            ltDades.Sort();
            cmbSecundari.DataSource = ltDades.ToArray();
            cmbSecundari.ResetText();
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            obrirFitxer.Filter = "XML files |*.xml";
            if (obrirFitxer.ShowDialog() == DialogResult.OK)
            {
                texFitxer.Text = obrirFitxer.FileName;
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            List<FoodDelivered> myPlanets;

            if (cmbOpcions.SelectedIndex > -1 && cmbSecundari.SelectedIndex > -1)
            {
                myPlanets = XMLSearch((string)cmbOpcions.SelectedItem, (string)cmbSecundari.SelectedItem);

                XMLOperations.SaveFile(myPlanets, false);
                rtbDades.LoadFile("dades.xml", RichTextBoxStreamType.PlainText);
            }
        }

        private void butAppend_Click(object sender, EventArgs e)
        {
            List<FoodDelivered> myPlanets;

            if (cmbOpcions.SelectedIndex > -1 && cmbSecundari.SelectedIndex > -1)
            {
                myPlanets = XMLSearch((string)cmbOpcions.SelectedItem, (string)cmbSecundari.SelectedItem);

                XMLOperations.SaveFile(myPlanets, true);
                rtbDades.LoadFile("dades.xml", RichTextBoxStreamType.PlainText);
            }
        }

        private List<FoodDelivered> XMLSearch(string strOpcio, string strSecundari)
        {
            List<FoodDelivered> myFoodsDelivered;

            switch (strOpcio)
            {
                case "Hosts":
                    myFoodsDelivered = XMLOperations.SearchHost(strSecundari, dtFoodsDelivered);
                 break;
                case "Refugees":
                    myFoodsDelivered = XMLOperations.SearchRefugee(strSecundari, dtFoodsDelivered, dtHosts);
                    break;
                case "Foods":
                    myFoodsDelivered = XMLOperations.SearchFood(strSecundari, dtFoodsDelivered);
                    break;
                case "FoodsDelivered":
                    myFoodsDelivered = XMLOperations.SearchFoodDelivered(strSecundari, dtFoodsDelivered);
                    break;
                default:
                    myFoodsDelivered = new List<FoodDelivered>();
                    break;
            }

            return myFoodsDelivered;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
