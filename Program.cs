using System;

namespace RunLengthEncoding
{
    class Program
    {
        public static void printRunLengthEncoding(String str)
        {
            int n = str.Length;
            for (int i = 0; i < n; i++)
            {
                //count the occurence of current character
                int count = 1;
                while (i < n - 1 && str[i] == str[i + 1])
                {
                    count++;
                    i++;
                }
               // print character and its count
                Console.Write(str[i]);
                Console.Write(count);
            }
        }
        static void Main(String[] args)
        {
            String str = "wwwwaaadexxxxxxywww";
            printRunLengthEncoding(str);
        }
    }
}
