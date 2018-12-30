using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "a";
            char[] c= { 'a' };
            object obj = new string(c);
            Console.WriteLine(s1 == obj);
            Console.WriteLine(s1.Equals(obj));
            string name = "ABCD";
            char[] ch = name.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                Console.WriteLine(ch[i]);
                int x = Convert.ToInt32(ch[i]);
                Console.WriteLine(x);
               // ch[i] = 'X';
            }
            string str = new string(ch);
            Console.WriteLine(str);
            string x1=str.Substring(2);
            string x2 = str.Substring(1,2);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.ReadLine();
        }
    }
}
