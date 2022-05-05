using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string input = "My name is Deepak and People call me Deepak";
		string[] wordList = input.Split();
		Dictionary<string, int> wordD = new Dictionary<string,int>();
		foreach(string str in wordList)
		{
			if(!wordD.ContainsKey(str))
            {
                wordD.Add(str,1);
            }
            else
            {
                wordD[str]= wordD[str]+1;
            }
		}
		foreach(KeyValuePair<string,int> de in wordD)
		{
			if(de.Value >1)
			{
				Console.WriteLine(de.Key);
			}
		}
	}
}
