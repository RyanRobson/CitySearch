using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CitySearch
{
    public class CitySearcher : ICityFinder, ICityResult
    {
        static public Collection<string> searchCities = LoadData.InitData();

        private Collection<string> nextCities;
        private Collection<string> nextLetters;
        public ICollection<string> NextCities { get { return nextCities; } set { nextCities = (Collection<string>)value; } }

        public ICollection<string> NextLetters { get { return nextLetters; } set { nextLetters = (Collection<string>)value; } }

        public CitySearcher()
        {
            nextCities = new Collection<string>();
            nextLetters = new Collection<string>();
            nextCities = (Collection<string>)NextCities;
            nextLetters = (Collection<string>)NextLetters;

        }
        public CitySearcher(Collection<string> nxtLetters, Collection<string> nxtCities)
        {
            nextCities = nxtCities;
            nextLetters = nxtLetters;

        }
        public Collection<string> getNextLetters() {
            return nextLetters;
        }

        public Collection<string> getNextCities() {
            return nextCities;
        }


        public ICityResult Search(string searchString)
        {

            CitySearcher cs = new CitySearcher();
            
            int cityLen = searchString.Length; //keeps track of number of letters in City Name
            string nxtCityString = "";  //Strings used to build output 
            string nxtLetterString = "";

            try
            {
                if (cityLen > 0)
                {
                    foreach (string st in searchCities)
                    {
                        {
                            if (st.Length > cityLen)
                            {
                                string subStr = st.Substring(0, cityLen); //

                                if (subStr.Contains(searchString))
                                {
                                    nextCities.Add(st);

                                    string letterSubStr = st.Substring(cityLen, 1);
                                    if (!nextLetters.Contains(letterSubStr))
                                    {
                                        nextLetters.Add(letterSubStr);
                                    }

                                    nxtCityString = string.Join(Environment.NewLine, nextCities.ToArray());
                                    nxtLetterString = string.Join(Environment.NewLine, nextLetters.ToArray());

                                }

                            }
                        }
                    }
                    Console.WriteLine("The list of cities: \n" + nxtCityString);
                    Console.WriteLine("The List of next Characters \n" + nxtLetterString);
                    return new CitySearcher(nextLetters, nextCities);
                }
                else {
                    //nxtCityString="";
                   // nxtLetterString = "";
                    Console.WriteLine("No Search String Entered");
                    return new CitySearcher(null,null);


                }   
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("There is no list of cities available");
                return new CitySearcher(null,null);
            }

        }




        public static void Main()
        {
            Console.Write("Enter Search String: ");
            string sr = Console.ReadLine();
            CitySearcher cs = new CitySearcher();
            CitySearcher searchR = (CitySearcher)cs.Search(sr);
           
            
        }


    }
}

