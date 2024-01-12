using AssessmentDotNet;

public class Developer
{
    public int Id;
    public string DeveloperName;
    public DateOnly JoiningDate;
    public string ProjectAssigned;
    List<Developer> list = new List<Developer>();

    public Developer()
    {
        Id = 0;
        DeveloperName = string.Empty;
        JoiningDate = new DateOnly();
        ProjectAssigned = string.Empty;
    }

    public void Get()
    {
        Console.WriteLine("Enter Id");
        Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Developer Name");
        DeveloperName = Console.ReadLine();
        Console.WriteLine("Enter Joining Date");
        JoiningDate = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter Project Name as Assigned");
        ProjectAssigned = Console.ReadLine();
        //d = new OnContractBasis();
        //list.Add(d);
        list.Add(new Developer
        {
            Id = Id,
            DeveloperName = DeveloperName,
            JoiningDate = JoiningDate,
            ProjectAssigned = ProjectAssigned
        });

    }

    public void Display()
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"Developer Id {list[i].Id}");
            Console.WriteLine($"Developer Name {list[i].DeveloperName}");
            Console.WriteLine($"Joining Date {list[i].JoiningDate}");
            Console.WriteLine($"Project Assigned  {list[i].ProjectAssigned}");
        }

    }

}