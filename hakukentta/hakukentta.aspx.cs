using System;
using System.Web.UI;

namespace Satamavahti
{
    public partial class WebForm : System.Web.UI.Page
    {
        // Tämä voi olla esimerkki tiedoista, joita voisi tulla tietokannasta.
        private static readonly string[] satamat = { "Hanko", "Helsinki", "Inkoo", "Kotka-Hamina", "Loviisa", "Sköldvik" };
        private static readonly string[] laivat = { "Purjelaiva", "Soutuvene", "Moottorivene", "Kanootti" };

        // Tiedot aluksesta
        private static string[] alustenTiedot =
        {
            "Purjelaiva: 12 metriä pitkä, 3 metriä leveä, nopeus 10 solmua.",
            "Soutuvene: 4 metriä pitkä, 1.2 metriä leveä, nopeus 5 solmua.",
            "Moottorivene: 8 metriä pitkä, 2.5 metriä leveä, nopeus 30 solmua.",
            "Kanootti: 5 metriä pitkä, 1 metri leveä, nopeus 3 solmua."
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            // Tarkistetaan, onko lomake lähetetty
            if (IsPostBack)
            {
                // Haetaan valitut tiedot
                string valittuSatama = Request.Form["satama"];
                string valittuLaiva = Request.Form["laiva"];

                // Haetaan aluksen tiedot valitun aluksen perusteella
                string laivanTiedot = "";

                switch (valittuLaiva)
                {
                    case "purjelaiva":
                        laivanTiedot = alustenTiedot[0];
                        break;
                    case "soutuvene":
                        laivanTiedot = alustenTiedot[1];
                        break;
                    case "moottorivene":
                        laivanTiedot = alustenTiedot[2];
                        break;
                    case "kanootti":
                        laivanTiedot = alustenTiedot[3];
                        break;
                }

                // Näytetään tiedot
                Tiedot = $"Satama: {valittuSatama}<br>Laiva: {valittuLaiva}<br>Tiedot: {laivanTiedot}";
            }
        }

        public string Tiedot { get; set; }
    }
}