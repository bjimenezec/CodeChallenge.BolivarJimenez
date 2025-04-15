using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static Challenge.BolivarJimenez.Common.Common;

namespace Challenge.BolivarJimenez.Helpers;
public static class Helper
{
    private static StringBuilder output { get; set; }= new StringBuilder();

    private static Dictionary<string,int> keyStrokes = new Dictionary<string,int>();
    const char SendKey = '#';     // Send key
    const char DelKey = '*';      // Delete key

    public static string OldPhonePad(string input)
    {
        output.Clear();
        output.Append(ProcessInput(input));
        
        return output.ToString();
    }

    private static StringBuilder ProcessInput(string rawInput)
    {
        StringBuilder convertedText = new StringBuilder();

        string input = RemoveSendCharacter(ref rawInput);           // Remove send (last) character (#).

        string[] groups = input.Split(' ');                     // Split the string by spaces to create a new array.

        for(int i = 0; i < groups.Length; i++)                  // Iterate through each group
        {
            string currentGroup = groups[i];
            string lastKey = string.Empty;
            int count = 0;

            if (!String.IsNullOrEmpty(currentGroup))
            {
                currentGroup = RemoveDeletedCharacters(ref currentGroup);

                foreach (char group in currentGroup)                 //  Count character occurrences.
                {
                    string currentKey = group.ToString();

                    if (keyStrokes.ContainsKey(currentKey))
                    {
                        keyStrokes[currentKey]++;
                    }
                    else
                    {
                        keyStrokes.Add(currentKey, 1);
                    }

                    if (currentKey != lastKey && !string.IsNullOrEmpty(lastKey))
                    {
                        MapCharacters(convertedText, lastKey, count);
                        count = 0;
                    }

                    count++;
                    lastKey = currentKey;
                }

                // Append last character group
                if (!string.IsNullOrEmpty(lastKey))
                {
                    MapCharacters(convertedText, lastKey, count);
                }
            }
        }

        return convertedText;
    }

    private static string RemoveDeletedCharacters(ref string word)
    {        
        StringBuilder tempString = new StringBuilder();

        for (int k = 0; k < word.Length; k++)
        {
            if (word[k] == DelKey)
            {
                // If the '*' is not at the beginning, remove the previous character from the temp string
                if (tempString.Length > 0)
                {
                    tempString.Length--;  // Remove the last character added to temp string
                }
            }
            else
            {
                // Append non '*' characters to temp string
                tempString.Append(word[k]);
            }
        }

        word = tempString.ToString();
        return word;
    }

    private static string RemoveSendCharacter(ref string word)
    {
        // Removes the SendKey ('#'), which is expected to be at the end of the input string.
        if (!string.IsNullOrEmpty(word) && word.EndsWith(SendKey.ToString()))
        {
            // Remove the last character
            word = word.Substring(0, word.Length - 1);
        }
        return word;
    }


    private static void MapCharacters(StringBuilder mappedString, string key, int occurrence)
    {
        // Map characters from the keypad based on the key and its occurrence. 
        if (KeyPad.TryGetValue(key, out var characters))
        {
            int index = (occurrence - 1) % characters.Count;
            mappedString.Append(characters[index]);
        }
    }
}
