using System;
using System.Text;
using System.Collections.Generic;

class Utility
{
    
    public bool Lexi(string a, string b)
    {
        if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            return false;
        if (a.Contains(" ") || b.Contains(" "))
            return false;
        return true;
    }

    public string ProcessWords(string a, string b)
    {

        char[] arr = a.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        if (reversed.Equals(b, StringComparison.OrdinalIgnoreCase))
        {
            reversed = reversed.ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (char ch in reversed)
            {
                if ("aeiou".Contains(ch))
                    sb.Append('@');
                else
                    sb.Append(ch);
            }
            return sb.ToString();
        }
        else
        {
            string combined = (a + b).ToUpper();

            int vowels = 0, consonants = 0;
            foreach (char ch in combined)
            {
                if ("AEIOU".Contains(ch))
                    vowels++;
                else if (char.IsLetter(ch))
                    consonants++;
            }

            if (vowels == consonants)
                return "Vowels and Consonants are Equal";

          HashSet<char> seen = new HashSet<char>();
StringBuilder result = new StringBuilder();
string check;

if (vowels > consonants)
{
    check = "AEIOU";
}
else
{
    check = "BCDFGHJKLMNPQRSTVWXYZ";
}

for (int i = 0; i < combined.Length; i++)/
{
    char ch = combined[i];

    // check if this char is in the group we need (vowel or consonant)
    if (check.Contains(ch) && seen.Add(ch)) // add only if unique
    {
        result.Append(ch);
    }

    if (result.Length == 2) // stop after first 2 unique letters
        break;
}

return result.ToString();
        }
    }
}