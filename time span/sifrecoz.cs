using System;
namespace time_span
{
    public class Sifrecoz
    {
        internal static string Sifrecozz(int k, string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    int b = (s[i] - 64 - k) % 26 + 64;
                    result += (char)b;
                }
                else
                {
                    int b = (s[i] -96 - k) % 26 + 96;
                    result += (char)b;
            }
                }return result;
        }
    }
}
