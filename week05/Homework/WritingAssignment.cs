// Derived Class: WritingAssignment
public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}"; // Directly accessing _studentName as it's now protected
    }
}