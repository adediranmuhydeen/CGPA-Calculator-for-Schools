using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekOne.Ui
{
    public class inputFromUser
    {
        public static string UserInput(string prompt)
        {
            Console.WriteLine($"\nEnter {prompt} ");
            return Console.ReadLine();
        }
    }
}
