using static System.Console;

namespace CorSchool.Util
{
    public static class Printer
    {
        public static void PrintLine(int len){
            WriteLine(new string('-', len));
        }

        public static void PrintTitle(string title)
        {
            PrintLine(title.Length);   
            WriteLine(title);
            PrintLine(title.Length);   
        }
    }
}