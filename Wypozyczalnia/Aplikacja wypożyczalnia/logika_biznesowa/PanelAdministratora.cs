using System;
using System.Data;
namespace logika_biznesowa {
	public class PanelAdministratora {
        /// <summary>
        /// metoda zalogowania siê do systemu
        /// </summary>
        public static bool ZalogujSie(string l, string h, ref string exmsg)
        {
            if (string.IsNullOrWhiteSpace(h))
                return false;
            string zapytanie = "Select haslo from [dbo].[Panel_administratora] where Login='" + l + "'";
            DataTable dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            if (!string.IsNullOrWhiteSpace(exmsg))
                return false;
            string hasloZBazy = "";
            foreach (DataRow item in dt.Rows)
            {
                hasloZBazy = item[0].ToString();
            }
            if (h == hasloZBazy)
                return true;
            else
                return false;
        }
	}
}
