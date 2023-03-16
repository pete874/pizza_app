using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace pizza_app
{
    class YHDISTA
    {
        //Tallennetaan yhteys nimiseen muuttujaan haluamamme database lähde. Muuttujan tyyppi/metodi on tässä tapauksessa MySqlConnection
        private MySqlConnection yhteys = new MySqlConnection("datasource = localhost; port = 3306; username = root; password =; database = pizza_app; convert zero datetime=True");


        //Tehdään functio, joka pelkästään palauttaa yhteys muttujan
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        //Funktio avaa yhteyden Open komennolla, jos yhteyden tila on kiinni function ajo hetkellä
        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        //Funktio sulkee yhteyden close komennolla, jos yhteyden tila on auki funktion ajo hetkellä
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
