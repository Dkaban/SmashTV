/*************************
 * 
 * Palindrome.cs
 * 
 * Author: Dustin Kaban
 * Date: November 25th, 2020
 * 
 * This class handles Palindrome checking (Practice, not practical for the program)
 * 
 *************************/

using UnityEngine;
using System.Linq;

public class Palindrome : MonoBehaviour
{
    string wordToTest = "ogopogO";

    void Start()
    {
        //Display to user result (Using Linq)
        //Debug.Log("Is " + wordToTest + " a Palindrome? (Using Linq): " + checkPalindromeUsingLinq());
        //Display to user result (Not Using Linq)
        //Debug.Log("Is " + wordToTest + " a Palindrome? (Not Using Linq): " + checkPalindromeUsingLoop());
    }

    bool checkPalindromeUsingLinq()
    {
        //Have to set this word to lowercase or else we get wrong result if mixed case
        wordToTest = wordToTest.ToLower();
        return wordToTest.SequenceEqual(wordToTest.Reverse());
    }

    bool checkPalindromeUsingLoop()
    {
        //If the wordToTest is empty, we don't want to continue and it is not a palindrome
        if (wordToTest.Equals("")) return false;

        //We're assuming true before we begin
        bool isPalindrome = true;

        //Left index approaches from the left, right index approaches from the right
        int leftIndex = 0;
        int rightIndex = wordToTest.Length - 1;

        //Set the word to all lowercase so we're not battling Upper and Lower as potentially "different"
        wordToTest = wordToTest.ToLower();

        while(leftIndex < rightIndex)
        {
            //If the letters do not match, it's concluded to not be a palindrome
            if(!wordToTest[leftIndex].Equals(wordToTest[rightIndex]))
            {
                isPalindrome = false;
                break;
            }

            //Increment and decrement the indexes so we can continue through the word
            leftIndex++;
            rightIndex--;
        }

        return isPalindrome;
    }
}
