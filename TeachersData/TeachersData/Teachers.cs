// Teacher.cs
using System;

[Serializable]
class Teacher
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string ClassSection { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Class and Section: {ClassSection}";
    }
}
