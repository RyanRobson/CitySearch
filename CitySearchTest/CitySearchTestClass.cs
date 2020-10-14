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
        public void Search_Text_Case2()
        {
            //Arrange 
            string searchString = "Lago";

            Collection<string> expectedNextLetters = new Collection<string>();
            Collection<string> expectedNextCities = new Collection<string>();

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

            CitySearcher cs = new CitySearcher();

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
    }




}
