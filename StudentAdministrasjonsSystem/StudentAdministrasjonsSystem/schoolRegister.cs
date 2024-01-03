using System.Security.Cryptography;

namespace StudentAdministrasjonsSystem;

public class schoolRegister
{
    private List<Student> students = new List<Student>();
    private List<Subject> subjects = new List<Subject> ();

    public void AddSchoolData() {
        var mat = new Subject("mat", "Math", 10);        
        var nor = new Subject("nor", "Norsk", 10);         
        var eng = new Subject("eng", "Engelsk", 10);         
        var guf = new Subject("guf", "Guffe", 50);
        subjects.Add(mat);
        subjects.Add(nor);
        subjects.Add(eng);
        subjects.Add(guf);
        
        var eskil = new Student("Eskil", 25, "Programming", 1001);
        eskil.AddGrade(new Grade(nor, 5 ));
        eskil.AddGrade(new Grade(mat, 2 ));     
        
        var jenny = new Student("Jenny", 23, "Theatre", 1002);
        jenny.AddGrade(new Grade(eng, 2 ));
        jenny.AddGrade(new Grade(nor, 6 ));
        
        var terje = new Student("Terje", 24, "E-Sports", 1003);
        terje.AddGrade(new Grade(guf, 5 ));
        terje.AddGrade(new Grade(nor, 5 ));
         
        students.Add(eskil);
        students.Add(jenny);
        students.Add(terje);
    }
    
    public void StudentRegister()
    {
        do
        {
            Console.WriteLine("Main Menu:\n" +
                              "1. Add student\n" +
                              "2. Add subject\n" +
                              "3. Add grade\n" +
                              "4. Show student information\n" +
                              "5. Show subject information\n" +
                              "6. show grade information\n" +
                              "7. show average grade\n" +
                              "8. show study points\n" +
                              "9. quit");

            char option = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (option)
            {
                case '1':
                    AddStudent();
                    break;
                case '2':
                    AddSubject();
                    break;
                case '3':
                    AddGrade();
                    break;
                case '4':
                    ShowStudents();
                    break;
                case '5':
                    ShowSubjects();
                    break;
                case '6':
                    ShowGrades();
                    break;
                case '7':
                    ShowAverageGrade();
                    break;
                case '8':
                    ShowTotalPoints();
                    break;
                case '9':
                    Console.WriteLine("Closing program");
                    return;
                default:
                    Console.WriteLine("Invalid option. try agian");
                    break;
            }

            Console.WriteLine("\nPress a button to continue");
            Console.ReadKey();
            Console.Clear();
        } while (true);
    }

    private void AddStudent()
    {
        Console.WriteLine("Name of new student?");
        string name = Console.ReadLine();
        Console.WriteLine("age?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("study program?");
        string studyProgram = Console.ReadLine();
        Console.WriteLine("student ID?");
        int studentId = Convert.ToInt32(Console.ReadLine());
        students.Add(new Student(name, age, studyProgram, studentId));
    }

    private void AddSubject()
    {
        Console.WriteLine("Subject code?");
        string subjectCode = Console.ReadLine();
        Console.WriteLine("Name Subject");
        string subjectName = Console.ReadLine();
        Console.WriteLine("number of studypoints");
        int studypoints = Convert.ToInt32(Console.ReadLine());
        subjects.Add(new Subject(subjectCode, subjectName, studypoints));

    }

    private void AddGrade()
    {
        Console.WriteLine("current students");
        foreach (var student in students)
        {
            student.PrintInfo();
        }
        
        Console.WriteLine("Enter Student ID to choose student");
        int studentId = Convert.ToInt32(Console.ReadLine());

        Student selectedStudent = students.FirstOrDefault(s => s.StudentId == studentId);

        if (selectedStudent == null)
        {
            Console.WriteLine("Invalid student ID");
            return;
        }
        
        Console.WriteLine("\n Available subjects");
        foreach (var subject in subjects)
        {
            Console.WriteLine($"Code: {subject.SubjectCode} subject: {subject.SubjectName}");
        }
        
        Console.WriteLine($"Enter the subject ID");
        string subjectId = Console.ReadLine();
        Subject selectedSubject = subjects.FirstOrDefault(s => s.SubjectCode == subjectId);

        if (selectedSubject == null)
        {
            Console.WriteLine("Invalid subject ID");
            return;
        }
        
        Console.WriteLine("enter grade:");
        char gradeValue = Convert.ToChar(Console.ReadLine());

        Grade newGrade = new Grade( selectedSubject, gradeValue);
        
        selectedStudent.AddGrade(newGrade);
        Console.WriteLine("Grade added");
    }

    private void ShowStudents()
    {
        
        foreach (var student in students)
        {
            student.PrintInfo();
        }
    }

    private void ShowSubjects()
    {
        foreach (var subject in subjects)
        {
            subject.PrintInfo();
        }
    }

    private void ShowGrades()
    {
        foreach (var student in students) {
            student.ShowGrades();
        }
    }

    private void ShowAverageGrade() 
    {
        Console.WriteLine("Average Grades on students");
        foreach (var student in students)
        {
            student.PrintName();
            Console.WriteLine($" average grade: {student.AverageGrade()}");
        }
    }

    public int TotalStudyPoints()
    {
        int totalPoints = 0;
        foreach (var subject in subjects)
        {
            totalPoints += subject.StudyPoints;
        }

        return totalPoints;
    }
    private void ShowTotalPoints()
    {
        Console.WriteLine("Total study points on students");
        foreach (var student in students)
        {
            student.PrintName();
            Console.WriteLine($"Total study points: {TotalStudyPoints()}");
        }
    }
}