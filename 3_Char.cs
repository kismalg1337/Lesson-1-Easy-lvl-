using System;

namespace CSharp_Shell
{

    class Char 
    {
        public static void Main() 
        {
           var ch1 = Convert.ToChar(Console.ReadLine());    
           int code = ch1;    
           ch1 = (char)(code +1);  
           string s = ch1.ToString();  
           Console.WriteLine(s);
        }
    }
}