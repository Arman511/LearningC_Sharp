using System.Diagnostics;

internal class Human
{
    private string firstName;
    private string lastName;
    private string? middleName;
    private int age;
    public Human(string gFirstName, string gLastName, int age)
    {
        this.firstName = char.ToUpper(gFirstName[0]) + gFirstName[1..].Trim();
        this.lastName = char.ToUpper(gLastName[0]) + gLastName[1..].Trim();
        this.age = age;
    }
    public Human(string gFirstName, string gMiddleName, string gLastName, int age)
    {
        this.firstName = char.ToUpper(gFirstName[0]) + gFirstName[1..].Trim();
        this.middleName = char.ToUpper(gMiddleName[0]) + gMiddleName[1..].Trim() + " ";
        this.lastName = char.ToUpper(gLastName[0]) + gLastName[1..].Trim();
        this.age = age;
    }
    public void IntroduceMyself() => Console.WriteLine("Hello I am {0} {1}{2}", firstName, middleName, lastName);

    ~Human()
    {
        Console.WriteLine("Deconstructed Human"); 
        Debug.WriteLine("Human was deconstructed");

    }
}