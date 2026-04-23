using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPR_testing
{

    public enum TypZbrane
    {
        Mec = 0,
        Luk = 1,
        Hul = 2,
        Dyky = 3
    }

    public enum TypBrneni
    {
        Latove = 0,
        Kozene = 1,
        Latkove = 2
    }
    public class Dobrodruh : ClenCechu
    {

        private string povolani;
        public string Povolani
        {
            get { return povolani; }
            set
            {
                
                if (value == "Válečník" || value == "Hraničář" || value == "Mág" || value == "Zloděj")
                {
                    povolani = value;
                }
            }
        }

        private TypZbrane zbran = 0;
        private TypBrneni brneni = 0;

        public int Zkusenosti = 0;

        public Dobrodruh(string jmeno, string povolani, TypZbrane zbran, TypBrneni brneni) : base(jmeno)
        {
            Povolani = povolani; 
            this.zbran = zbran;
            this.brneni = brneni;
        }

        public void PridejZkusenosti(int xp)
        {
          
        }

        public bool PouzijSchopnost()
        {
            return true;
        }

        public override string ToString()
        {
            
            return base.ToString() + $" | Povolání: {Povolani} | Zbraň: {zbran} | Brnění: {brneni} | Zkušenosti: {Zkusenosti}";
        }
    }
}
