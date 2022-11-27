using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekOne.Ui
{
    public static class Table
    {
        internal static void gpaTable()
        {
            //Console.Clear();
            Console.Title = "CGPA Calculator";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("|-----------------|-----------------------|------------|-----------------------|");
            Console.WriteLine("| COURSE & CODE   | COURSE UNIT | GRADE | GRADE-UNIT | WEIGHT Pt.  | REMARK    |");
            Console.WriteLine("|-----------------|-----------------------|------------|-----------------------|");
            Console.WriteLine($"|MTH101          |   5         |   B     |   4        | 20         | Very Good|");
            Console.WriteLine("| GS101           |   3         |   A     |   5        | 15         | Excellent|");
            Console.WriteLine("| NET101          |   5         |   C     |   3        | 15         | Good     |");
            Console.WriteLine("| C#101|          |   5         |   B     |   4        | 20         | Very Good|");
            Console.WriteLine("| HCI101          |   3         |   F     |   0        | 0          | Fail     |");
            Console.WriteLine("|------------------------------------------------------------------------------|");
        }
    }
}
