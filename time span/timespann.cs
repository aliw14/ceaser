using System;
namespace time_span
{
	public class Timespann
	{
		internal static string Timespan(string time1, string time2)

		{
			int h1 = int.Parse(time1.Substring(0, 2));
			int m1 = int.Parse(time1.Substring(3, 2));
			int s1 = int.Parse(time1.Substring(6, 2));


            int h2 = int.Parse(time2.Substring(0, 2));
            int m2 = int.Parse(time2.Substring(3, 2));
            int s2 = int.Parse(time2.Substring(6, 2));

			int h3 = h2 - h1;
			int m3 = m2 - m1;
			int s3 = s2 - s1;
			string result = $"0{h3}:0{m3}:{s3}";

			return result;
        }		

	}
}

