// Program.cs
using System;

class Program
{
    static void Main()
    {
        TeacherDataManager teacherManager = new TeacherDataManager();

        // Load existing data from file
        teacherManager.LoadData();

        while (true)
        {
            Console.WriteLine("1. Add Teacher");
            Console.WriteLine("2. Update Teacher");
            Console.WriteLine("3. Display Teachers");
            Console.WriteLine("4. Save and Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Teacher ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Teacher Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Class and Section: ");
                    string classSection = Console.ReadLine();
                    teacherManager.AddTeacher(new Teacher { ID = id, Name = name, ClassSection = classSection });
                    break;

                case 2:
                    Console.Write("Enter Teacher ID to update: ");
                    int updateId = int.Parse(Console.ReadLine());
                    Console.Write("Enter new Teacher Name: ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter new Class and Section: ");
                    string newClassSection = Console.ReadLine();
                    teacherManager.UpdateTeacher(updateId, newName, newClassSection);
                    break;

                case 3:
                    teacherManager.DisplayTeachers();
                    break;

                case 4:
                    // Save data to file and exit
                    teacherManager.SaveData();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        Console.ReadKey();
    }
}
