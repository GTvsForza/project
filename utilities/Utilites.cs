using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities {

	public static string ProcessText (string input)
    {
        // Determine wether user has input word or number       
        float result;

        if (float.TryParse(input, out result))
        {
            // Return string "number" if user enters number
            return ("Number");
        }
        else
        {
            // Return string "word" if user enters word
            return ("Word");
        }
    }
}
