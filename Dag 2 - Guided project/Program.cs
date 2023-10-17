using System;
using System.Runtime.InteropServices;

// initialize variables - graded assignments 
string student;
int currentAssignments = 5;
int numberOfPeople = 4;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int Class;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;
int classSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;
decimal classScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;
classScore = (decimal)(sophiaScore + andrewScore + emmaScore + loganScore) / numberOfPeople;

Console.WriteLine("Which students score would you like to see?");
Console.WriteLine("Sophia");
Console.WriteLine("Andrew");
Console.WriteLine("Emma");
Console.WriteLine("Logan");
Console.WriteLine("Class");

student = Console.ReadLine();

if (student == "Sophia")
{
    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
}
else if (student == "Andrew")
{
    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
}
else if (student == "Emma")
{
    Console.WriteLine("student\t\tGrade\n");
    Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
}
else if (student == "Logan")
{
    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");
}
else if (student == "Class")
{
    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Class:\t\t" + classScore + "\tB+");
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

