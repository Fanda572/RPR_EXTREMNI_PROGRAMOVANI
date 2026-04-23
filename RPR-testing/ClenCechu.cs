using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPR_testing
{
    public class ClenCechu
    {

        public int energie = 50;
        public string jmeno;
        public int zdravi = 100;
        public bool jeAktvini = true;
        public int uroven = 1;

        public int Uroven {  get; }
        public string Jmeno {  get; set; }
        public int Zdravi { get; } 

        public int Energie { get; }

        public bool JeAktivni { get; }

        public ClenCechu(string jmeno)
        {

        }

        public void Trenuj(int pocet) { }

        public void UtrzZraneni(int dmg) { }

        public virtual void Odpocivej() { }

        public override string ToString()
        {
            return $"{Jmeno} | {energie} | {Zdravi} | {JeAktivni} | {Uroven}";
        }
    }
}
