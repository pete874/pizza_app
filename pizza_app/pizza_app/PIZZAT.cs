using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace pizza_app
{
    class PIZZAT
    {
        YHDISTA yhteys = new YHDISTA();
        public DataTable HaePizzat()
        {
            // tehdään uusi mysqlcommand. Sulkeiden sisään tulee itse komento ja otaYhteys funktio. MySqlCommand(String, MySqlConnection)
            MySqlCommand haeKaikki = new MySqlCommand("SELECT pizza, hinta FROM pizzat", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            taulu.Columns.Add("pizzahinta", typeof(string), "pizza + ' ' + hinta + '€'");
            return taulu;
        }

        public DataTable HaeTaytteet()
        {
            // tehdään uusi mysqlcommand. Sulkeiden sisään tulee itse komento ja otaYhteys funktio. MySqlCommand(String, MySqlConnection)
            MySqlCommand haeKaikki = new MySqlCommand("SELECT aines, hinta FROM ainekset", yhteys.otaYhteys());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = haeKaikki;
            adapter.Fill(taulu);

            //Haetaan mahdollisesti myös ainesten hinnat esiin. Kommentoidaan toistaiseksi ulos
            //taulu.Columns.Add("aineshinta", typeof(string), "aines + ' ' + hinta + '€'");
            return taulu;
        }
    }
}
