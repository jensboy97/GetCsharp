using System.Net.Sockets;

namespace StudentAdministrasjonsSystem;

public class Student
{
    private string _name;
    private int _age;
    private string StudyProgram { get; set;}
    public int StudentId { get; set;}
    
    private List<Subject> _subjects = new List<Subject>();
    private List<Grade> _grades = new List<Grade>();
    
    public Student(string name, int age, string studyprogram, int studentId)
    {
        _name = name;
        _age = age;
        StudyProgram = studyprogram;
        StudentId = studentId;
    }
    
    public void AddGrade(Grade grade)
    {
        _grades.Add(grade);
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {_name}\n " +
                          $"Age: {_age}\n" +
                          $"Study program: {StudyProgram}\n" +
                          $"StudentId: {StudentId}\n ");
    }

    public void PrintName()
    {
        Console.WriteLine($"Name: {_name}");
    }
    public void ShowGrades() {
        foreach(var grade in _grades) {
            grade.PrintInfo(_name);
        }
    }

    public double AverageGrade()
    {
        if (_grades.Count == 0)
            return 0;
        double totalGrade = 0;
        foreach (var grade in _grades)
        {
            totalGrade += grade.GradeValue;
        }

        return totalGrade / _grades.Count;
    }

   
}