using System;
using System.Collections.Generic;

namespace Sean_OOP_ASS1
{
    //https://docs.microsoft.com/en-us/visualstudio/debugger/edit-and-continue?view=vs-2019
    //https://www.w3schools.com/cs/cs_abstract.asp [ABSTRACT METHODS TO THIS FILE]
    //A class for each country
    public class Country
    {
        //DATA MEMBERS
        //------------------------------------------------------
        //Set abstraction preventing country name reassignment (State Variable)
        public string Name { get; private set; } = "";

        //No encapsulation on last three variables as we will be manipulating both in other .cs files
        public float Population = 0.0f;
        public char Vote = 'x';
        public bool Participation = true;

        //Object Constructor
        public Country(string Cname, float Cpopulation, char Cvote, bool Cparticipation)
        {
            //Link class variables
            Name = Cname;
            Population = Cpopulation;
            Vote = Cvote;
            Participation = Cparticipation;
        }

       
        
    }
}