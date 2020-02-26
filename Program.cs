using System;
using System.Collections.Generic;

namespace Sean_OOP_ASS1
{
    class Program
    {
        public string vote = "";
        static void Main(string[] args)
        {
            //Object instantiation during creation of List
            List<Country> CountryList = new List<Country>();
            CountryList.Add(new Country("austria", 1.98f, 'x', true));
            CountryList.Add(new Country("Belgium", 2.56f, 'x', true));
            CountryList.Add(new Country("Bulgaria", 1.56f, 'x', true));
            CountryList.Add(new Country("Croatia", 0.91f, 'x', true));
            CountryList.Add(new Country("Cyprus", 0.2f, 'x', true));
            CountryList.Add(new Country("Czech Republic", 2.35f, 'x', true));
            CountryList.Add(new Country("Denmark", 1.3f, 'x', true));
            CountryList.Add(new Country("Estonia", 0.3f, 'x', true));
            CountryList.Add(new Country("Finland", 1.23f, 'x', true));
            CountryList.Add(new Country("France", 14.98f, 'x', true));
            CountryList.Add(new Country("Germany", 18.54f, 'x', true));
            CountryList.Add(new Country("Greece", 2.4f, 'x', true));
            CountryList.Add(new Country("Hungary", 2.18f, 'x', true));
            CountryList.Add(new Country("Ireland", 1.1f, 'x', true));
            CountryList.Add(new Country("Italy", 13.65f, 'x', true));
            CountryList.Add(new Country("Latvia", 0.43f, 'x', true));
            CountryList.Add(new Country("Lithuania", 0.62f, 'x', true));
            CountryList.Add(new Country("Luxembourg", 0.14f, 'x', true));
            CountryList.Add(new Country("Malta", 0.11f, 'x', true));
            CountryList.Add(new Country("Netherlands", 3.89f, 'x', true));
            CountryList.Add(new Country("Poland", 8.49f, 'x', true));
            CountryList.Add(new Country("Portugal", 2.3f, 'x', true));
            CountryList.Add(new Country("Romania", 4.34f, 'x', true));
            CountryList.Add(new Country("Slovakia", 1.22f, 'x', true));
            CountryList.Add(new Country("Slovenia", 0.47f, 'x', true));
            CountryList.Add(new Country("Spain", 10.49f, 'x', true));
            CountryList.Add(new Country("Sweden", 2.29f, 'x', true));

              void ParticipatingCountries(string Name)
            {
                int Index = -1;
                foreach (var Country in CountryList)
                {
                    Index++;
                    string Nation = (Name);
                    if((Nation == (Country.Name)))
                    {
                        CountryList[Index].Participation = false;
                        Console.WriteLine("done");
                        break;
                    }
                }
            }

            //Repeat program until user chooses not to
            bool Repeat = true;
            while(Repeat == true)
            {

                //PROGRAM DISPLAY START
                char countryRule = 'x';
                char votingRule = 'x';
                Console.WriteLine("Hello, this is the European Union Council Voting calculator.\nDo you wish to use:\n\nAll European Countries: 'A'\n           or\nOnly Eurozone Countries: 'U'\n\nA/U: ");
                countryRule = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\nWhat voting rule should be used?\n\nQualified Majority: 'Q'\nReinforced Qualified Majority: 'R'\nSimple Majority: 'S'\nUnanimy: 'U'");
                votingRule = Convert.ToChar(Console.ReadLine());
                votingRule = char.ToUpper(votingRule);

                //Set Participating Countries
                foreach (var Country in CountryList)
                {
                    if (countryRule == 'U')
                    {
                        CountryList[2].Participation = false;
                        CountryList[3].Participation = false;
                        CountryList[5].Participation = false;
                        CountryList[6].Participation = false;
                        CountryList[12].Participation = false;
                        CountryList[20].Participation = false;
                        CountryList[22].Participation = false;
                        CountryList[26].Participation = false;
                    }
                }
                //Iterates through CountryList and Allows the user to choose the participating countries
                while (true)
                {
                    Console.WriteLine("Are all the Countries Voting?\nYes:Y/y \n No: N/n");
                    var Answer = Console.ReadLine();
                    if (Answer == "Y" ^ Answer == "y")
                    {
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Enter Name of Non Participating Country");
                        ParticipatingCountries(Console.ReadLine());
                    
                    
                    }
                }
                //Iterate through CountryList and set vote variable based on user input
                foreach (var Country in CountryList)
                {
                    if (Country.Participation == true) 
                    {
                    
                        Console.WriteLine($"\nWhat is {Country.Name}'s vote?\n\nYes: 'Y'\nNo: 'N'\nAbstain: 'A'\n");
                        Country.Vote = Convert.ToChar(Console.ReadLine());
                        Country.Vote = char.ToUpper(Country.Vote);
                    
                    
                    }
                   
                }

                //Count included Countries
                int Ccount = 0;
                foreach (var Country in CountryList)
                {
                    if (Country.Participation == true)
                    {
                        Ccount++;
                    }
                }

                //Sum of Participating Countries' Percentages to get Calculatable value
                float Sum = 0;//Sum variable for totalling Population
                foreach (var Country in CountryList)
                {
                    if (Country.Participation == true)
                        Sum = Country.Population + Sum;
                }
                Sum = (float)Math.Round(Sum, MidpointRounding.AwayFromZero);
                Console.WriteLine(Sum);

                //Divide each population percentage by 'Sum' and multiply by 100 to get changed percentage
                Console.WriteLine();
                foreach (var Country in CountryList)
                {
                    if (Country.Participation == true)
                    {
                        //Algorithm for Percentage of Population
                        Country.Population = ((Country.Population / Sum) * 100);
                        //Console.WriteLine($"{Country.Name} | {Country.Population}");
                    }
                }

                //Print each country from List
                foreach (var Country in CountryList)
                {
                    Console.WriteLine("Current Accessible Countries: Name: {0} | Population: {1}% | Vote: {2}", Country.Name, Country.Population, Country.Vote);
                }

                //Repeat Sum for changed Population values
                Sum = 0;
                foreach (var Country in CountryList)
                {
                    Console.WriteLine($"Part = {Country.Participation}");
                    if (Country.Participation == true)
                        Sum = Country.Population + Sum;
                }

                //Calculate voting population for 'Yes'
                float voteSum = 0.0f; //Variable for suming votes
                foreach (var Country in CountryList)
                {
                    if (Country.Vote == 'Y' && Country.Participation == true)
                    {
                        Console.WriteLine(Country.Population);
                        voteSum = Country.Population + voteSum;
                    }
                }
                voteSum = (float)Math.Ceiling(voteSum);
                Console.WriteLine(voteSum);

                //Qualified Majority
                if (votingRule == 'Q' && voteSum >= 55)
                {
                    Console.WriteLine("APPROVED");
                }

                //Console.WriteLine(Sum);


                //Console.WriteLine(Math.Round(0.49, MidpointRounding.AwayFromZero));

                //CountryList[0].Name = "UK"; //public/private, encapsualtion example
                //Console.WriteLine(CountryList[0].Name);

                //country iteration required for easy voting rule/countries participating

                Repeat = false;

                Console.WriteLine("\n\nDo you want to repeat the program? (Y/N)");
                if(Console.ReadLine() == "Y")
                {
                    Repeat = true;
                }
                else if(Console.ReadLine() == "N")
                {
                    break;
                }


          
                     
         
            
            }
        }
       
    }
}