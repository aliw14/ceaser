using System;
namespace time_span
{
    public class Ceaser
    {
        internal static string Ceaserr(int k, string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    int b = (s[i] - 64 + k) % 26 + 64;
                    if (b <= 64)
                    b = b + 26;
                    result += (char)b;
                }
                else
                {
                    int c = (s[i] - 96 + k) % 26 + 96;
                    if (c <= 96)
                    c = c + 26;
                    result += (char)c;
                }

            }
                    return result;

        }
    }
}             
            
        
    
