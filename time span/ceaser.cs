using System;
namespace time_span
{
       public class Ceaser
	{
	      public static string Ceaserr(int k, string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
			{
			   result += (char)(s[i] + k);
			}
     
            for (int i = 0;  i< s.Length; i++)
            {
                result += (char)(s[i] - k);
            }
            return result;
            
        }
                                    
    }
}

