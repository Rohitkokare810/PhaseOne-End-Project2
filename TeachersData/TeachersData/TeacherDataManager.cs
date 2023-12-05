// TeacherDataManager.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class TeacherDataManager
{
    private List<Teacher> teachers = new List<Teacher>();
    private const string FilePath = "F:/teachers.dat";

    public void LoadData()
    {
        if (File.Exists(FilePath))
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                teachers = (List<Teacher>)formatter.Deserialize(fs);
            }
        }
    }

    public void SaveData()
    {
        using (FileStream fs = new FileStream(FilePath, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, teachers);
        }
    }

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public void UpdateTeacher(int id, string name, string classSection)
    {
        Teacher teacherToUpdate = teachers.Find(t => t.ID == id);
        if (teacherToUpdate != null)
        {
            teacherToUpdate.Name = name;
            teacherToUpdate.ClassSection = classSection;
        }
    }

    public void DisplayTeachers()
    {
        foreach (var teacher in teachers)
        {
            Console.WriteLine(teacher);
        }
    }
}
