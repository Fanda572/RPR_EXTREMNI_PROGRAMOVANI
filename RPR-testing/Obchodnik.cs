using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPR_testing
{

    public enum TypObchodu
    {
        Lektvary = 0,
        Zbrane = 1,
        Brneni = 2,
        Jidlo = 3
    }

    public class Obchodnik : ClenCechu
    {

        public TypObchodu typObchodu;
        public bool MaSlevu;
        public int PocetPredmetu = 10;

        public Obchodnik(string jmeno, TypObchodu typObchodu, bool maSlevu) : base(jmeno)
        {
            this.typObchodu = typObchodu;
            this.MaSlevu = maSlevu;
        }

        public Obchodnik(string jmeno, TypObchodu typObchodu) : this(jmeno, typObchodu, false)
        {
        }
        public void Prodej(int pocet)
        {
            
        }

        public void DoplnZbozi(int pocet)
        {
           
        }
        public  override void Odpocivej()
        {
           
        }

        public override string ToString()
        {
            return base.ToString() + $" | Typ obchodu: {typObchodu} | Má slevu: {MaSlevu} | Skladem: {PocetPredmetu} ks";
        }
    }
}
