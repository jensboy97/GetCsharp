namespace StudentAdministrasjonsSystem;

public class Grade
{
    public Subject Subject { get; set; }
    public int GradeValue { get; set; }

    public Grade( Subject subject, int gradeValue)
    {
        Subject = subject;
        GradeValue = gradeValue;
    }
    
    public void PrintInfo(string name)
    {
        Console.WriteLine($"Student: {name}\n" +
                          $"Subject: {Subject.SubjectName}\n" +
                          $"Grade: {GradeValue}\n");
    }
}