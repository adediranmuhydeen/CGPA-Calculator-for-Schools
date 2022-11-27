// See https://aka.ms/new-console-template for more information
using weekOne.Implementations;
using weekOne.Ui;

Console.ForegroundColor = ConsoleColor.Cyan;
Greet.Greeting();


string tableRow;
int weightPoint = 0;

string tableHead = "|-----------------|-----------------------|------------|-----------------------|\n| COURSE & CODE   | COURSE UNIT | GRADE   | GRADE-UNIT | WEIGHT Pt. | REMARK  \n|-----------------|-----------------------|------------|-----------------------|";

double totalWeightPoint = 0.00;
double totalCourseUnit = 0.00;

wait:
int numberOfCourses = Checker.Convert<int>("Enter Your Number of Courses");
if (numberOfCourses > 25)
{
    Console.WriteLine("Out Range, Please Try again");
    goto wait;
}
Console.WriteLine($"You take {numberOfCourses} Course(s)");

while (numberOfCourses > 0)
{
start:
    string courseNameAndCode = Checker.Convert<string>("Enter your Course name and code: ");
    if (courseNameAndCode.Length < 5 || courseNameAndCode.Length > 6)
    {
        Console.WriteLine("Course Name and Code Should be between 5 and 6 Characters, Please Try Again");
        goto start;
    }
    Console.WriteLine($"Your Course Name and Code is {courseNameAndCode}");

    int courseUnit = Checker.Convert<int>("Enter your Course Unit: ");
    Console.WriteLine($"Your Course Unit is: {courseUnit}");
Label:
    int courseScore = Checker.Convert<int>("Enter your Course Score: ");
    Loop.SetScore(courseScore);
    if (courseScore > 100)
    {
        Console.WriteLine("Course Cannot Exceed 100, Please Try Again");
        goto Label;
    }
    Console.WriteLine($"Your Course Score is: {courseScore}");

    weightPoint = courseUnit * Loop.scoreUnit;
    tableRow = ($"\n|  {courseNameAndCode}         |    {courseUnit}        |   {Loop.scoreGrade}     |   {Loop.scoreUnit}        | {weightPoint}         | {Loop.remark}");
    tableHead += tableRow;
    totalWeightPoint += (double)weightPoint;
    totalCourseUnit += (double)courseUnit;
    numberOfCourses--;
}

Console.WriteLine(tableHead);
double gpa = totalWeightPoint / totalCourseUnit;
decimal finalGPA = (decimal)Math.Round(gpa, 2);
Console.WriteLine($"\n Total Course Unit Passed is {totalCourseUnit}\n Total Weight Point is {totalWeightPoint}\n Your GPA is = {finalGPA} to 2 decimal places.");
Console.ReadLine();