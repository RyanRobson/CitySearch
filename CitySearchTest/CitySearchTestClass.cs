using Microsoft.VisualStudio.TestTools.UnitTesting;
using CitySearch;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System;

namespace CitySearchTest
{
    [TestClass]
    public class CitySearchTestClass
    {

        [TestMethod]
        public void Search_With_Empty_String()
        {

            //Arange

            string searchString = "";

            CitySearcher cs = new CitySearcher();
            Collection<string> actualNextLetters = new Collection<string>();
            Collection<string> actualNextCities = new Collection<string>();

            //Act


            CitySearcher csr = (CitySearcher)cs.Search(searchString);


            //Assert

            actualNextCities = (Collection<string>)csr.NextCities;
            actualNextLetters = (Collection<string>)csr.NextLetters;

            Assert.IsNull(actualNextCities);
            Assert.IsNull(actualNextLetters);
        }

        [TestMethod]
        public void Search_TestCase1()
        {
            //Arrange 
            string searchString = "Dib";
            Collection<string> expectedNextLetters = new Collection<string>();
            Collection<string> expectedNextCities = new Collection<string>();
            CitySearcher cs = new CitySearcher();

            expectedNextCities.Add("Dibba Al-Fujairah");
            expectedNextCities.Add("Dibba Al-Hisn");
            expectedNextCities.Add("Dibrugarh");
            expectedNextCities.Add("Dibai");


            expectedNextLetters.Add("b");
            expectedNextLetters.Add("r");
            expectedNextLetters.Add("a");


            
            Collection<string> actualNextLetters = new Collection<string>();
            Collection<string> actualNextCities = new Collection<string>();

            //Act
            CitySearcher csr = (CitySearcher)cs.Search(searchString);

            //Assert

            actualNextCities = csr.getNextCities();
            actualNextLetters = csr.getNextLetters();
            CollectionAssert.AreEquivalent(expectedNextLetters, actualNextLetters);
            CollectionAssert.AreEquivalent(expectedNextCities, actualNextCities);


        }
        [TestMethod]
        public void Search_Test_Case_Lago()
        {
            //Arrange 
            string searchString = "Lago";

            Collection<string> expectedNextLetters = new Collection<string>();
            Collection<string> expectedNextCities = new Collection<string>();
            Collection<string> actualNextLetters = new Collection<string>();
            Collection<string> actualNextCities = new Collection<string>();
            CitySearcher cs = new CitySearcher();
           

            expectedNextCities.Add("Lago da Pedra");
            expectedNextCities.Add("Lagoa do Itaenga");
            expectedNextCities.Add("Lagoa Vermelha");
            expectedNextCities.Add("Lagoa Santa");
            expectedNextCities.Add("Lagoa da Prata");
            expectedNextCities.Add("Lagos de Moreno");
            expectedNextCities.Add("Lagos");
            expectedNextCities.Add("Lagos");

            expectedNextLetters.Add(" ");
            expectedNextLetters.Add("a");
            expectedNextLetters.Add("s");


            //Act

            CitySearcher csr = (CitySearcher)cs.Search(searchString);

            //Assert
            actualNextCities = csr.getNextCities();
            actualNextLetters = csr.getNextLetters();
            CollectionAssert.AreEquivalent(expectedNextLetters, actualNextLetters);
            CollectionAssert.AreEquivalent(expectedNextCities, actualNextCities);

        }
        [TestMethod]
        public void Search_Test_Case_Bang()
        {
            //Arrange
            string searchString = "Bang";
            Collection<string> expectedNextLetters = new Collection<string>();
            Collection<string> expectedNextCities = new Collection<string>();
            Collection<string> actualNextLetters = new Collection<string>();
            Collection<string> actualNextCities = new Collection<string>();
            CitySearcher cs = new CitySearcher();
            
            expectedNextCities.Add("Bangassou");
            expectedNextCities.Add("Bangui");
            expectedNextCities.Add("Bangolo");
            expectedNextCities.Add("Bangangté");
            expectedNextCities.Add("Bangor");
            expectedNextCities.Add("Bangor");
            expectedNextCities.Add("Bangkalan");
            expectedNextCities.Add("Bangil");
            expectedNextCities.Add("Bangārapet");
            expectedNextCities.Add("Bangaon");
            expectedNextCities.Add("Bangaon");
            expectedNextCities.Add("Banganapalle");
            expectedNextCities.Add("Banga");
            expectedNextCities.Add("Bang Saphan");
            expectedNextCities.Add("Bang Phae");
            expectedNextCities.Add("Bangkok");
            expectedNextCities.Add("Bang Rakam");
            expectedNextCities.Add("Bang Racham");
            expectedNextCities.Add("Bang Pakong");
            expectedNextCities.Add("Bang Pa-in");
            expectedNextCities.Add("Bang Mun Nak");
            expectedNextCities.Add("Bang Len");
            expectedNextCities.Add("Bang Lamung");
            expectedNextCities.Add("Bang Kruai");
            expectedNextCities.Add("Bang Krathum");
            expectedNextCities.Add("Bang Bua Thong");
            expectedNextCities.Add("Bang Ban");
            expectedNextCities.Add("Bang Bo District");
            expectedNextCities.Add("Bangor");

            expectedNextLetters.Add("a");
            expectedNextLetters.Add("u");
            expectedNextLetters.Add("o");
            expectedNextLetters.Add("k");
            expectedNextLetters.Add("i");
            expectedNextLetters.Add("ā");
            expectedNextLetters.Add(" ");

            //Act
            CitySearcher csr = (CitySearcher)cs.Search(searchString);

            //Assert
            actualNextCities = csr.getNextCities();
            actualNextLetters = csr.getNextLetters();
            CollectionAssert.AreEquivalent(expectedNextLetters, actualNextLetters);
            CollectionAssert.AreEquivalent(expectedNextCities, actualNextCities);
        }
    }

}
