namespace mvc_etc.Models;

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public Branch? Branch { get; set; }
    public Gender? Gender { get; set; }
    public bool IsRegular { get; set; }
    public string? Address { get; set; }
    public DateTime DateOfBird { get; set; }
}