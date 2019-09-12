using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities {

	public static string ProcessText (string input)
    {
        // Determine wether user has input word or number       
        float result;

        int totalLetters = 0;
        double number;
        double numWords = 0;
        int numNumbers = 0;
        double avgChar = 0;


        try
        {
            string[] words = input.Split(' ', '.');

            foreach (var word in words)
            {
                totalLetters += word.Length;

                if (float.TryParse(input, out result))
                {
                    numNumbers++; 
                    
                    // Return string "number" if user enters number
                    // return ("Number");
                 }
                 else
                 {
                    numWords++;

                    avgChar = (totalLetters / numWords);
                    
                    // Return string "word" if user enters word
                    // return ("Word");
                  }
            }

            return ("" + avgChar + ", " + numWords);
        }
        catch
        {
            return ("Unable to parse");
        }
    }
}
