using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace WebApiPovezivanje.Models
{
    public class RadniZadatak
    {
        public int id { get; set; } 
        public string todo { get; set; }
        public string radnikIme { get; set; }
        public string radnikPrezime { get; set;}
        public string opisPosla { get; set; }
        public DateTime? datum { get; set; }
        public bool isDone { get; set; }
       

    }
}
