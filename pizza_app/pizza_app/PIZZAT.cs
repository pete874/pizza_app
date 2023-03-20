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

        public bool LisaaTilaus(String etunimi, String sukunimi, String lahiosoite, String postinumero, String puhelin, String email, String tuotteet)
        {
            MySqlCommand komento = new MySqlCommand();

            //Tallennetaan stringiin SQL kysely. Tämä voidaan myös laittaa suoraan MySqlCommandin sulkeiden sisään yhteys-funktion kanssa, niikuin ylimmässä funktiossa on tehty.
            String lisaysKysely = "INSERT INTO asiakkaat " + "(etunimi, sukunimi, lahiosoite, postinumero, puhelin, email, tuotteet) " +
                "VALUES (@enm, @snm, @los, @pnm, @puh, @ema, @tuo); ";

            //Asettaa Stringin SQL komennoksi komento muuttujaan
            komento.CommandText = lisaysKysely;

            //Asettaa otaYhteys funktion SQL yhteydeksi Connection komennolla.  Tämä voidaan myös laittaa yhteydeksi MySqlCommandin sisään pilkun jälkeen toiseksi parametriksi
            komento.Connection = yhteys.otaYhteys();

            //Tehdään C# puolelta luettavat muuttujat, joita voidaan käyttää SQL komennossa. Huom. Normaalit C# muuttujat eivät toimi SQL komennossa.
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = etunimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sukunimi;
            komento.Parameters.Add("@los", MySqlDbType.VarChar).Value = lahiosoite;
            komento.Parameters.Add("@pnm", MySqlDbType.VarChar).Value = postinumero;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@ema", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@tuo", MySqlDbType.VarChar).Value = tuotteet;

            yhteys.avaaYhteys();

            //ExecuteNonQuerya käytetään SQL komentoihin, joilla ei palauteta dataa vaan pelkästään tallennetaan dataa tietokantaan(UPDATE,INSERT,DELETE)
            //Jos SQL-lisäyskysely onnistuu esimerkiksi päivittämään rivin tietokannnassa, palauttaa ExecuteNonQuery int-tyyppinä vaikutuksen alaisena olevien rivien määrän
            // eli kuinka monta riviä esim päivitetty tai poistettu.
            // Tässä kyseisessä komennossa rivejä palautuu aina yksi, jos on onnistuttu muuttamaan dataa. Jos yhtäkään riviä ei muutettu, palautuu numero -1
            //Alhaalla tarkistetaan onko riviä onnistuttu muuttamaan ja palautetaan joko true tai false boolean.
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
