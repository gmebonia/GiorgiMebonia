//Students ertganzomilebiani masivi 


string[] students = new string[3];

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"Enter students name {i + 1};");
    students[i] = Console.ReadLine();
}
Console.WriteLine("List of students");
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"{i + 1} {students[i]}");
}


//Grade organzomilebiani masivi

using System.Runtime;

int[,] grades = new int[3, 2];
string[] studentNames = new string[3];

for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine($"Enter students name {i + 1};");
    studentNames[i] = Console.ReadLine();

}

{
    for (int i = 0; i < grades.GetLength(0); i++)
        for (int j = 0; j < grades.GetLength(1); j++)
        {
            Console.Write($"Enter students {studentNames[i]} {j + 1} score: ");
            grades[i, j] = int.Parse(Console.ReadLine());
        }
}
Console.WriteLine("student scores:");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine($"{studentNames[i]}: {grades[i, 0]}, {grades[i, 1]}");
}