// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int samlSophia = sophia1+ sophia2+sophia3+sophia4+sophia5;
int samlNicolas = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int samlZahirah = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int samlJeong = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

double genSophia = samlSophia / currentAssignments;
double genNicolas = samlNicolas / currentAssignments;
double genZahirah = samlZahirah / currentAssignments;
double genJeong = samlJeong / currentAssignments;

Console.WriteLine("Sophia "+genSophia);
Console.WriteLine("Nicolas "+genNicolas);
Console.WriteLine("Zahirah "+genZahirah);
Console.WriteLine("Jeong "+genJeong);

int students = 4;
double samlGennemsnit = (genSophia+ genNicolas+genZahirah+genJeong) / students;
Console.WriteLine("");
Console.WriteLine("Collective Grade Point Average of the class " + samlGennemsnit);