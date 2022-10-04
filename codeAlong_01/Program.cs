Using System;
 

namespace CodeAlong_01{

    class Program {

        static void Main(string[] args){
        // I want to print to the console my name and age 
        // and a brief description of myself;
        v// What do we know about C-Sharp
    // We still have VALUE-TYPES
    // strings, integers, arrays, floats, booleans


                        
                //type    name        value
                int biggestNumberOnEarth = 0;

                // let biggestNumberOnEarth =0;
                bool isComplete = false;

                // how do I make a string

                string myGuitar = "ghost";

                int[] ages = {21,22,23,24,25,26,27,28,29,30,31};
                // _____________________________________________________________
                
            string myName = "Marcus";

            int marcusAge = 25;

            string marcusJob = "softwareDeveloper";

            string funFact = "I absolutely loves swimming!";

            Console.WriteLine($"my name is {myName}, I am {marcusAge} years old. For a living, I am a {marcusJob}. Fun Fact: {funFact}");
        }
    }
}

