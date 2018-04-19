using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;


namespace TelefoonWindow
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string TelefoonNummer { get; set; }
        public string Groep { get; set; } // familie,werk,vrienden
        public BitmapImage Foto { get; set; }
        public Persoon(string nNaam,string nTelefoonNummer,string nGroep, BitmapImage nFoto)
        {
            Naam = nNaam;
            TelefoonNummer = nTelefoonNummer;
            Groep = nGroep;
            Foto = nFoto;
        }
    }
}
