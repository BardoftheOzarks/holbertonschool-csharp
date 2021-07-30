using System;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            if (s.Length > 0)
            {
                for (int l = 0, r = s.Length - 1; l < r; l++, r--)
                {
                    while (!Char.IsLetter(s[l]))
                        l++;
                    while (!Char.IsLetter(s[r]))
                        r--;
                    if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
                        return false;
                }
            }
            return true;
        }
    }
}
