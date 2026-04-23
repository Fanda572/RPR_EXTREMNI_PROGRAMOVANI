using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPR_testing;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_Konstruktor_NastaviJmeno()
        {
            string jmeno = "Gimli";
            ClenCechu clen = new ClenCechu(jmeno);
            Assert.AreEqual(jmeno, clen.Jmeno);
        }

        [TestMethod]
        public void Test_Jmeno_Neplatne()
        {
            ClenCechu clen = new ClenCechu("Puvodni");
            clen.Jmeno = ""; 
            Assert.AreEqual("Puvodni", clen.Jmeno);

            clen.Jmeno = null; 
            Assert.AreEqual("Puvodni", clen.Jmeno);
        }

        [TestMethod]
        public void Test_Jmeno_PrilisDlouhe()
        {
            ClenCechu clen = new ClenCechu("Puvodni");
            clen.Jmeno = "DlouheJmenoNadDvanactZnaku";
            Assert.AreEqual("Puvodni", clen.Jmeno);
        }

        [TestMethod]
        public void Test_Spravne_VychoziStaty()
        {
            ClenCechu clen = new ClenCechu("Test");
            Assert.AreEqual(100, clen.Zdravi);
            Assert.AreEqual(50, clen.Energie);
            Assert.AreEqual(1, clen.Uroven);
            Assert.IsTrue(clen.JeAktivni);
        }


        [TestMethod]
        public void Test_Trenuj_ZvysiEnergii()
        {
            ClenCechu clen = new ClenCechu("Test");
            clen.Trenuj(20);
            Assert.AreEqual(70, clen.Energie);
        }

        [TestMethod]
        public void Test_Trenuj_Max()
        {
            ClenCechu clen = new ClenCechu("Test");
            clen.Trenuj(100);
            Assert.AreEqual(100, clen.Energie);
        }

        [TestMethod]
        public void Test_Trenuj_Zaporne()
        {
            ClenCechu clen = new ClenCechu("Test");
            clen.Trenuj(-50);
            Assert.AreEqual(50, clen.Energie);
        }

        [TestMethod]
        public void Test_UtrzZraneni_SniziZdravi()
        {
            ClenCechu clen = new ClenCechu("Test");
            clen.UtrzZraneni(30);
            Assert.AreEqual(70, clen.Zdravi);
        }

        [TestMethod]
        public void Test_UtrzZraneni_Nula_Deaktivuje()
        {
            ClenCechu clen = new ClenCechu("Test");
            clen.UtrzZraneni(150);
            Assert.AreEqual(0, clen.Zdravi);
            Assert.IsFalse(clen.JeAktivni);
        }

        [TestMethod]
        public void Test_Odpocivej_DoplniZdraviIEnergii()
        {
            ClenCechu clen = new ClenCechu("Test");
            clen.UtrzZraneni(20);        
            clen.Odpocivej();

            Assert.AreEqual(90, clen.Zdravi); 
            Assert.AreEqual(55, clen.Energie); 
        }

        [TestMethod]
        public void Test_Spravne_Povolani()
        {
            Dobrodruh d = new Dobrodruh("Gimli", "Válečník", TypZbrane.Mec, TypBrneni.Latove);
            Assert.AreEqual("Válečník", d.Povolani);
            d.Povolani = "Mág";
            Assert.AreEqual("Mág", d.Povolani);
        }

        [TestMethod]
        public void Test_Neplatne_Povolani()
        {
            Dobrodruh d = new Dobrodruh("Gimli", "Válečník", TypZbrane.Mec, TypBrneni.Latove);
            d.Povolani = "Programátor";
            Assert.AreEqual("Válečník", d.Povolani);
        }

        [TestMethod]
        public void Test_Zkusenosti_Zvyseni()
        {
            Dobrodruh d = new Dobrodruh("Legolas", "Hraničář", TypZbrane.Luk, TypBrneni.Kozene);
            d.PridejZkusenosti(50);
            Assert.AreEqual(50, d.Zkusenosti);
        }

        [TestMethod]
        public void Test_Zkusenosti_LevelUp()
        {
            Dobrodruh d = new Dobrodruh("Legolas", "Hraničář", TypZbrane.Luk, TypBrneni.Kozene);
            d.PridejZkusenosti(100);

            Assert.AreEqual(2, d.uroven);
            Assert.AreEqual(100, d.Zkusenosti); 
        }

        [TestMethod]
        public void Test_Zkusenosti_Zaporne()
        {
            Dobrodruh d = new Dobrodruh("Legolas", "Hraničář", TypZbrane.Luk, TypBrneni.Kozene);
            d.PridejZkusenosti(-500);
            Assert.AreEqual(0, d.Zkusenosti);
        }

        [TestMethod]
        public void Test_Schopnost_DostatekEnergie()
        {
            Dobrodruh d = new Dobrodruh("Gandalf", "Mág", TypZbrane.Hul, TypBrneni.Latkove);
            bool vysledek = d.PouzijSchopnost();

            Assert.IsTrue(vysledek);
            Assert.AreEqual(40, d.energie); 
        }

        [TestMethod]
        public void Test_Schopnost_MaloEnergie_Selhani()
        {
            Dobrodruh d = new Dobrodruh("Gandalf", "Mág", TypZbrane.Hul, TypBrneni.Latkove);
            d.energie = 5;

            bool vysledek = d.PouzijSchopnost();

            Assert.IsFalse(vysledek);
            Assert.AreEqual(5, d.energie); 
        }

        [TestMethod]
        public void Test_Konstruktor1_NastaviVsechnyVlastnosti()
        {
            Obchodnik o = new Obchodnik("BezelstnyArnost", TypObchodu.Lektvary, true);

            Assert.AreEqual("BezelstnyArnost", o.Jmeno);
            Assert.AreEqual(TypObchodu.Lektvary, o.typObchodu);
            Assert.IsTrue(o.MaSlevu);
            Assert.AreEqual(10, o.PocetPredmetu);
        }

        [TestMethod]
        public void Test_Konstruktor2_VychoziSleva_False()
        {
            Obchodnik o = new Obchodnik("Kramář", TypObchodu.Zbrane);
            Assert.IsFalse(o.MaSlevu);
        }

        [TestMethod]
        public void Test_Prodej_Kladny_SniziSklad()
        {
            Obchodnik o = new Obchodnik("Arnošt", TypObchodu.Jidlo);
            o.Prodej(5);
            Assert.AreEqual(5, o.PocetPredmetu);
        }

        [TestMethod]
        public void Test_Prodej_NeklesnePodNulu()
        {
            Obchodnik o = new Obchodnik("Arnošt", TypObchodu.Jidlo);
            o.Prodej(50);
            Assert.AreEqual(0, o.PocetPredmetu);
        }

        [TestMethod]
        public void Test_Prodej_Zaporny()
        {
            Obchodnik o = new Obchodnik("Arnošt", TypObchodu.Jidlo);
            o.Prodej(-10);
            Assert.AreEqual(10, o.PocetPredmetu);
        }

        [TestMethod]
        public void Test_DoplnZbozi_ZvysiPocet()
        {
            Obchodnik o = new Obchodnik("Arnošt", TypObchodu.Jidlo);
            o.DoplnZbozi(20);
            Assert.AreEqual(30, o.PocetPredmetu); 
        }

        [TestMethod]
        public void Test_Odpocivej_Obchodnik_DoplniJenZdravi()
        {
            Obchodnik o = new Obchodnik("Arnošt", TypObchodu.Jidlo);
            o.UtrzZraneni(20);
            o.Odpocivej();

            Assert.AreEqual(85, o.zdravi);
            Assert.AreEqual(50, o.energie);
        }
    }
}
