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
            
        }

        private void PizzaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String pizza = PizzaCB.Text.ToString();

            
            if (pizza == "Oma valinta 10€")
            {
                TayteCB.Visible = true;
                LisaaTayteBT.Visible = true;
            }
            else
            {
                TayteCB.Visible = false;
                LisaaTayteBT.Visible = false;
            }
        }

        public int loppuSumma = 0;
        private void LisaaPizzaBT_Click(object sender, EventArgs e)
        {
            String hinta = PizzaCB.SelectedValue.ToString();
            int hintaInt = Convert.ToInt16(hinta);
            loppuSumma += hintaInt;
            
            SummaLB.Text = loppuSumma.ToString() + "€";
        }
    }
}
