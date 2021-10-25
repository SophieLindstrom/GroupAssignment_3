using System;

namespace GroupAssignment3 //Sophie, Jonathan, Theo, Finan
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IStudentList myStudents = null;

            
            myStudents = new StudentList();

            Console.WriteLine("Empty student list");
            Console.WriteLine(myStudents.ToString());

            Console.WriteLine("\nStudent list");
            myStudents.CreateOOP1dotNet5();
            Console.WriteLine(myStudents.ToString());

            Console.WriteLine("\nSorted student list");
            myStudents.sortStrings();
            Console.WriteLine(myStudents.ToString());
            Console.WriteLine();
            
            
            //Using the General UserInput we made in one of the code exercises
            int NrOfGroups = 0;
            bool Continue = UserInput.TryReadInt32("How many groups do you want", 1, myStudents.NrOfStudents / 2, out NrOfGroups);
            if (!Continue) return;

            myStudents.NrOfGroups = NrOfGroups;
            
            Console.WriteLine($"If you make {NrOfGroups} group(s), each group will have {myStudents.NrStudentsInGroup} student(s) with {myStudents.NrStudentsNotInGroup} student(s) remaining to be placed in the groups.");
        }
        
    }
}
