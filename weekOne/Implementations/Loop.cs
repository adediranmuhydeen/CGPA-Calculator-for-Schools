using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace weekOne.Implementations
{
    public class Loop
    {
        public static string remark = "";
        public static string scoreGrade = "";
        public static int scoreUnit = 0;

        public static void SetScore(int score)
        {
            if (score >= 70 && score <= 100)
            {
                remark = "Excellent";
                scoreGrade = "A";
                scoreUnit = 5;
            }
            else if (score >= 60 && score <= 69)
            {
                remark = "Very Good";
                scoreGrade = "B";
                scoreUnit = 4;
            }
            else if (score >= 50 && score <= 59)
            {
                remark = "Good    ";
                scoreGrade = "C";
                scoreUnit = 3;
            }
            else if (score >= 45 && score <= 49)
            {
                remark = "Fair    ";
                scoreGrade = "D";
                scoreUnit = 2;
            }
            else if (score >= 40 && score <= 44)
            {
                remark = "Pass    ";
                scoreGrade = "E";
                scoreUnit = 1;
            }
            else if (score >= 0 && score <= 39)
            {
                remark = "Fail   ";
                scoreGrade = "F";
                score = 0;
            }
        }
    }
}
