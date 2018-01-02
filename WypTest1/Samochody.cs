using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WypTest1
{
    // klasa z baza samochodów
    public class Samochody
    {
        // lista samochodów
        List<Samochod> listaSamochodow = new List<Samochod>();

        // ściągnięcie wszystkich danych z tabeli Samochod
        // dla każdego wiesza z dataTable tworzony jest obiekt Samochod
        // następnie ww. obiekt dodawany jest do listy
        public void PobierzSamochodyZBazy(ref string exmsg)
        {
            string zapytanie = "select * from [dbo].[samochod]";
            DataTable dt = Funkcje.PobierzDaneSQL(zapytanie, ref exmsg);                
            foreach (DataRow item in dt.Rows)
            {
                listaSamochodow.Add(new Samochod(item[0].ToString(), int.Parse(item[1].ToString()), int.Parse(item[2].ToString())));
            }
        }

        // string z cala pobraną wyżej bazą
        public string WyswietlListeSamochodow()
        {
            string ls="";
            foreach (Samochod s in listaSamochodow)
            {
                ls += s.WyswietlSamochod();
                ls += "\n";
            }
            return ls;
        }
    }

    // klasa Samochod - SQL: pojedynczy wiersz tabeli z bazy, c#: element listySamochodów
    public class Samochod
    {
        string marka;
        // ApplicationIdentity id = new ApplicationIdentity("id");
            // to chyba powinno pozwolić na tworzenie unikalnych id, ale nie wiem, czy to dobry pomysł
            // abstrahujac od tego, że nie wiem, czy cała ta koncepcja trzyma się kupy
        int id;
        int rok;

        public Samochod()
        {
            marka = "-";
            id = -1;
            rok = -1;
        }

        public Samochod(string m, int i, int r)
        {
            marka = m;
            id = i;
            rok = r;
        }

        public string WyswietlSamochod()
        {
            return "Marka: " + marka + ",\t rocznik: " + rok + ", \tidentyfikator: " + id;
        }
    }
}
