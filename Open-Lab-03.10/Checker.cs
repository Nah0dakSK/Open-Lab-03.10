using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == letter)
                    res++;
            }
            return res;
        }
    }
}
