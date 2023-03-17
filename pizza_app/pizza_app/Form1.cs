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
            PizzaCB.DataSource = pizzat.HaePizzat();
            PizzaCB.DisplayMember = "pizzahinta";
            PizzaCB.ValueMember = "hinta";

            TayteCB.DataSource = pizzat.HaeTaytteet();
            TayteCB.DisplayMember = "aines";
            TayteCB.ValueMember = "hinta";

            OstoskoriDG.Columns.Add("Tuote", "Tuote");
            OstoskoriDG.Columns.Add("Tayte1", "Täyte1");
            OstoskoriDG.Columns.Add("Tayte2", "Täyte2");
            OstoskoriDG.Columns.Add("Tayte3", "Täyte3");
            OstoskoriDG.Columns.Add("Tayte4", "Täyte4");
            OstoskoriDG.Columns.Add("Hinta", "Hinta");

            // Muista muuttaa Visible = false
            OstoskoriDG.Columns["Hinta"].Visible = true;



        }

        private void PizzaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String pizza = PizzaCB.Text.ToString();

            
            if (pizza == "Oma valinta 10€")
            {
                TayteCB.Visible = true;
                LisaaTayteBT.Visible = true;
                TuotteetPN.Panel2.Visible = true;
            }
            else
            {
                TuotteetPN.Panel2.Visible = false;
            }
        }

        
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
            

            if (tuote == "Oma valinta 10€" && tayte1 != "" || tayte2 != "" || tayte3 != "" || tayte4 != "")
            {

                OstoskoriDG.Rows.Add(tuote, tayte1, tayte2, tayte3, tayte4, hinta);
                loppuSumma += hintaInt;
            }
            else if (tuote == "Oma valinta 10€" && tayte1 == "" && tayte2 == "" && tayte3 == "" && tayte4 == "")
            {
                MessageBox.Show("Valitse vähintään yksi täyte.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                OstoskoriDG.Rows.Add(tuote, tayte1, tayte2, tayte3, tayte4, hinta);
                loppuSumma += hintaInt;
            }
            
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
        }

        private void TuotteetBT_Click(object sender, EventArgs e)
        {
            OstoskoriPN.Visible = false;
        }

        private void TakaisinBT_Click(object sender, EventArgs e)
        {
            if (OstoskoriPN.Visible == true)
            {
                OstoskoriPN.Visible = false;
                TuotteetPN.Visible = true;
                MaksamaanBT.Visible = false;
                TakaisinBT.Visible = false;
            }
        }

        
        private void OstoskoriPoistaBT_Click(object sender, EventArgs e)
        {
            
            if (OstoskoriDG.SelectedRows.Count > 0) 
            {
                foreach (DataGridViewRow row in OstoskoriDG.SelectedRows)
                {
                    OstoskoriDG.Rows.RemoveAt(row.Index);
                }
                
                


            }
        }
    }
}
