using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            List<string> pleb = new List<string>();
            for(int i = 0; i < strings.Length;i++)   
                if (strings[i].Length == 4)
                {
                    pleb.Add(strings[i]);
                }
                else
                {

                }
            string[] bruh = pleb.ToArray();
            return bruh;




        }
    }
}
