string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science 101";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int courseAmount = 5;

double samlCredit = course1Credit+ course2Credit+course3Credit+course4Credit+course5Credit;
double gpa = samlCredit / courseAmount;

Console.WriteLine(studentName);
Console.WriteLine("");
Console.WriteLine(course1Name +" "+course1Credit);
Console.WriteLine(course2Name+" "+course2Credit);
Console.WriteLine(course3Name+" "+course3Credit);
Console.WriteLine(course4Name+" "+course4Credit);
Console.WriteLine(course5Name+" "+course5Credit);
Console.WriteLine("");
Console.WriteLine("Grade Point Average = "+gpa);