using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_app
{
    public partial class PizzaForm : Form
    {
        YHDISTA yhteys = new YHDISTA();
        PIZZAT pizzat = new PIZZAT();
        public PizzaForm()
        {
            InitializeComponent();
        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {
            //haetaan comboboxeihin tuotteita ja aineksia tietokannasta
            PizzaCB.DataSource = pizzat.HaePizzat();
            PizzaCB.DisplayMember = "pizzahinta";
            PizzaCB.ValueMember = "hinta";

            TayteCB.DataSource = pizzat.HaeTaytteet();
            TayteCB.DisplayMember = "aines";
            TayteCB.ValueMember = "hinta";

            //ostoskorin datagridiin sarakkeet
            OstoskoriDG.Columns.Add("Tuote", "Tuote");
            OstoskoriDG.Columns.Add("Tayte1", "Täyte1");
            OstoskoriDG.Columns.Add("Tayte2", "Täyte2");
            OstoskoriDG.Columns.Add("Tayte3", "Täyte3");
            OstoskoriDG.Columns.Add("Tayte4", "Täyte4");
            OstoskoriDG.Columns.Add("Hinta", "Hinta");

            // Muista muuttaa Visible = false
            OstoskoriDG.Columns["Hinta"].Visible = false;

           

        }


        private void PizzaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String pizza = PizzaCB.Text.ToString();

            //jos omavalinta valitaan, laitetaan täytteiden valinta näkyville
            if (pizza == "Oma valinta 10€")
            {
                TayteCB.Visible = true;
                LisaaTayteBT.Visible = true;
                TuotteetPNPB.Visible = false;
            }
            else
            {
                TuotteetPNPB.Visible = true;
            }
        }

        //muuttujat loppusummalle ja täytteille
        public int loppuSumma = 0;
        String tayte1 = "";
        String tayte2 = "";
        String tayte3 = "";
        String tayte4 = "";

        private void LisaaPizzaBT_Click(object sender, EventArgs e)
        {
            String tuote = PizzaCB.Text.ToString();
            String hinta = PizzaCB.SelectedValue.ToString();
            int hintaInt = Convert.ToInt16(hinta);
            
            //Varmistetaan if lauseella että tarvittavat tiedot menevät ostoskorin datagridiin ja ettei tyhjää omavalintaa pysty sinne lisäämäään
            if (tuote == "Oma valinta 10€" && tayte1 != "" || tayte2 != "" || tayte3 != "" || tayte4 != "")
            {
                //lisätään ostoskoriin tuotteet,täytteet ja hinta, kun painetaan lisää-nappia
                OstoskoriDG.Rows.Add(tuote, tayte1, tayte2, tayte3, tayte4, hinta);

                //lisätään lopulliseen hintaan valitun pizzan hinta
                loppuSumma += hintaInt;

                Tayte1LB.Visible = false;
                Tayte2LB.Visible = false;
                Tayte3LB.Visible = false;
                Tayte4LB.Visible = false;

                PTayte1BT.Visible = false;
                PTayte2BT.Visible = false;
                PTayte3BT.Visible = false;
                PTayte4BT.Visible = false;
            }

            //tarkastus, jotta oma valintaista pizzaa ei pysty lisäämään ilman yhtäkään täytettä
            else if (tuote == "Oma valinta 10€" && tayte1 == "" && tayte2 == "" && tayte3 == "" && tayte4 == "")
            {
                MessageBox.Show("Valitse vähintään yksi täyte.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                OstoskoriDG.Rows.Add(tuote, tayte1, tayte2, tayte3, tayte4, hinta);
                loppuSumma += hintaInt;
            }

            tayte1 = "";
            tayte2 = "";
            tayte3 = "";
            tayte4 = "";





            //lopuksi päivitetään lopullisen summan teksti vastaamaan loppuSumma muuttujaa
            SummaLB.Text = loppuSumma.ToString() + "€";



            /* Vaihtoehto tuotteiden lisäämiseksi Ostoskori paneeliin
             
            public int labelpoint = 35;

            Label tuote1 = new Label();
            labelpoint += 25;
            tuote1.Location = new Point(25, labelpoint);            
            tuote1.Text = tuote;
            OstoskoriPN.Controls.Add(tuote1);
            */
        }

        //maksimissaan neljän täytteen lisääminen omavalintaan
        private void LisaaTayteBT_Click(object sender, EventArgs e)
        {
            if (Tayte1LB.Visible == false)
            {
                tayte1 = TayteCB.Text.ToString();
                Tayte1LB.Text = tayte1;
                Tayte1LB.Visible = true;
                PTayte1BT.Visible = true;
            }
            else if (Tayte1LB.Visible == true && Tayte2LB.Visible == false) 
            {
                tayte2 = TayteCB.Text.ToString();
                Tayte2LB.Text = tayte2;
                Tayte2LB.Visible = true;
                PTayte2BT.Visible = true;
            }
            else if (Tayte2LB.Visible == true && Tayte3LB.Visible == false)
            {
                tayte3 = TayteCB.Text.ToString();
                Tayte3LB.Text = tayte3;
                Tayte3LB.Visible = true;
                PTayte3BT.Visible = true;
            }
            else if (Tayte3LB.Visible == true && Tayte4LB.Visible == false) 
            {
                tayte4 = TayteCB.Text.ToString();
                Tayte4LB.Text = tayte4;
                Tayte4LB.Visible = true;
                PTayte4BT.Visible = true;
            }


        }

        //täytteiden poistonappien toiminnallisuus
        private void PTayte1BT_Click(object sender, EventArgs e)
        {
            Tayte1LB.Text = "";
            Tayte1LB.Visible = false;
            PTayte1BT.Visible = false;
            tayte1 = "";
        }

        private void PTayte2BT_Click(object sender, EventArgs e)
        {
            Tayte2LB.Text = "";
            Tayte2LB.Visible = false;
            PTayte2BT.Visible = false;
            tayte2 = "";
        }

        private void PTayte3BT_Click(object sender, EventArgs e)
        {
            Tayte3LB.Text = "";
            Tayte3LB.Visible = false;
            PTayte3BT.Visible = false;
            tayte3 = "";
        }

        private void PTayte4BT_Click(object sender, EventArgs e)
        {
            Tayte4LB.Text = "";
            Tayte4LB.Visible = false;
            PTayte4BT.Visible = false;
            tayte4 = "";
        }

        private void OstoskoriinBT_Click(object sender, EventArgs e)
        {
            OstoskoriPN.Visible = true;
            MaksamaanBT.Visible = true;
            TakaisinBT.Visible = true;
            TuotteetPN.Visible = false;
        }


        //välilehtien takaisin-napin toiminnallisuus
        private void TakaisinBT_Click(object sender, EventArgs e)
        {
            if (TuotteetPN.Visible == true)
            {
                OstoskoriPN.Visible = false;
                TuotteetPN.Visible = true;
                MaksamaanBT.Visible = false;
                TakaisinBT.Visible = false;
                MaksaPN.Visible = false;
            }

            if (OstoskoriPN.Visible == true)
            {
                MaksamaanBT.Visible = false;
                MaksaPN.Visible = false;
                TakaisinBT.Visible = false;
                OstoskoriinBT.Visible = true;
                TuotteetPN.Visible = true;
                OstoskoriPN.Visible = false;
            }

            if (MaksaPN.Visible == true)
            {
                OstoskoriPN.Visible = true;
                TuotteetPN.Visible = false;
                MaksamaanBT.Visible = true;
                TakaisinBT.Visible = true;
                MaksaPN.Visible = false;
                OstoskoriinBT.Visible = false;
            }

        }

        
        private void OstoskoriPoistaBT_Click(object sender, EventArgs e)
        {
            //muuttuja, jolla voimme vähentää poistettujen pizzojen summan kokonaishinnasta
            int poistahinta = 0;
            
            //jos valitut rivit on isompi kuin nolla, suoritetaan seuraava
            if (OstoskoriDG.SelectedRows.Count > 0) 
            {
                //Loopataan läpi valitut rivit
                foreach (DataGridViewRow row in OstoskoriDG.SelectedRows)
                {
                    //haetaan valitun tuotteen hinta taulukosta ja muutetaan se int muotoon
                    String tuotehinta = Convert.ToString(OstoskoriDG.SelectedCells[5].Value);
                    int tuotehinta2 = Convert.ToInt32(tuotehinta);

                    //Tässä tehdään itse rivin poisto datagridistä
                    OstoskoriDG.Rows.RemoveAt(row.Index);

                    //lisätään poistahinta muuttujaan valitun tuotteen hinta
                    poistahinta += tuotehinta2;
                }

                //lopuksi vähennetään poistettujen pizzojen hinta loppusummasta
                loppuSumma -= poistahinta;
                


            }
            //Päivitetään hinta label vastaamaan loppusummaa
            SummaLB.Text = loppuSumma.ToString() + "€";

        }

        //tilauksen maksu ja lisäys tietokantaan, josta tilauksen ovat mahdollista saada keittiön puolelle haettua tietokannasta
        private void MaksaTilausBT_Click(object sender, EventArgs e)
        {
            String etunimi = EnimiTB.Text;
            String sukunimi = SnimiTB.Text;
            String lahiosoite = OsoiteTB.Text;
            String postinumero = PstNumTB.Text;
            String puhelin = PuhTB.Text;
            String email = EmailTB.Text;
            String tuotteet = "";

            for (int i = 0; i < OstoskoriDG.Rows.Count; i++)
            {
                tuotteet += OstoskoriDG.Rows[i].Cells["tuote"].Value + " " +
                            OstoskoriDG.Rows[i].Cells["tayte1"].Value + " " +
                            OstoskoriDG.Rows[i].Cells["tayte2"].Value + " " +
                            OstoskoriDG.Rows[i].Cells["tayte3"].Value + " " +
                            OstoskoriDG.Rows[i].Cells["tayte4"].Value + " ";
            }

            MessageBox.Show(tuotteet.ToString());

            if (etunimi.Trim().Equals("") || sukunimi.Trim().Equals("") || lahiosoite.Trim().Equals("") || postinumero.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || tuotteet.Trim().Equals(""))
            {
                MessageBox.Show("Täytä kaikki kentät", "Virhe syötössä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean LisaaTilaus = pizzat.LisaaTilaus(etunimi, sukunimi, lahiosoite, postinumero, puhelin, email, tuotteet);
                if (LisaaTilaus)
                {
                    MessageBox.Show("Uusi tilaus lisätty!", "Tilaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta tilausta ei pystytty lisäämään.", "Tilaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MaksamaanBT_Click(object sender, EventArgs e)
        {

            MaksaPN.Visible = true;
            MaksamaanBT.Visible = false;
            OstoskoriinBT.Visible = false;
            OstoskoriPN.Visible = false;

        }
    }
}
