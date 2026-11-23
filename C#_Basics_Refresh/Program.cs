internal class Program
{

    public class NameSpeller()
    {
        public string? Name { get; set; }

        public void NameTake()
        {
            Console.WriteLine("Please write in your name: ");

            Name = Console.ReadLine();
        }

        public void NameSpell()
        {
            if (Name != null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    Console.WriteLine(Name[i]);
                }
            }
        }
    }


    private static void Main(string[] args)
    {
        int newVar = 0;

        var newName = new NameSpeller();

        List<int> newArray = new List<int>();

        List<string> nameArray = new List<string>();

        Console.WriteLine("Hello, World!");

        Console.WriteLine("Welcome to the name speller.");

        newName.NameTake();

        newName.NameSpell();

        Console.WriteLine("The name that you just typed in is: " + newName.Name);
    }
}

