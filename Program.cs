using System;

namespace Count_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            CountVowel("Hello World");  // Calls the method and provides a test string of Hello World expecting a value of 3 vowels returned as a result.
            Console.WriteLine("\n");    // Line Break
            CountVowel("H3ll0 W0rld");  // Calls the method with other another test property with out vowels expecting a 0 value to be returned as a result.
            Console.WriteLine("\n");    // Line Break
            CountVowel("");             // Technically this would run correctly and return 0 because there are no vowels but we should probably add an exemption for Null or Empty Strings
        }                               // ** Should add additional try, catch blocks and exception handling ** /

        public static void CountVowel(string vowels )
        {
            
            int i; // Declaring i to be used below to identify my index in my loops.
            int count=0; //Declaring and instantiating my count variable and setting it to zero to hold and increase my count.

            vowels.ToLower(); // This sets the whole string to lower case letters so that we do not have to differentiate between upper and lower case.
            if (String.IsNullOrEmpty(vowels)) // This checks the string if it is Null or Empty.
            {
                Console.WriteLine("Your string is empty, please try again!"); // This will be returned if the string is Null or Empty.
                return; 
            }
            
            for (i=0;i<vowels.Length-1; i++) // This will iterate through each letter in the string one at a time.
            {
                // This will check each letter that is iterated to see whether or not it is a vowel.
                if(vowels[i]=='a'||vowels[i]=='e'||vowels[i]=='i'||vowels[i]=='o'||vowels[i]=='u')
                {
                    // This will increase the count for each vowel that it finds by one.
                    count++;
                }
                
            }
            Console.WriteLine("There are "+ count +" vowels in this string :" + vowels+"."); // This returns the updated count results to the console.
            
            
        }
    }
}
