namespace StudentAdministrasjonsSystem;

public class Subject
{
    public string SubjectCode;
    public string SubjectName;
    public int StudyPoints;

    public Subject(string subjectCode, string name, int studypoints)
    {
        SubjectCode = subjectCode;
        SubjectName = name;
        StudyPoints = studypoints;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Code: {SubjectCode}\n" +
                          $"Subject: {SubjectName}\n" +
                          $"Study points: {StudyPoints}\n");
    }
    
}