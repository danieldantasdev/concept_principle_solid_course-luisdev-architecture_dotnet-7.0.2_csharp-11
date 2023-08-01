namespace SolidPattern.Dip;

public class Person
{
    public string Name { get; set; }
    public string Document { get; set; }
    public DateTime BirthDate { get; set; }

    public Person(string name, string document, DateTime birthDate)
    {
        BirthDate = birthDate;
        Document = document;
        Name = name;
    }
}