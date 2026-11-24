using System.Runtime.InteropServices.Marshalling;

internal class Program
{

    public class NameSpeller()
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public void NameTake()
        {
            Console.WriteLine("Please write in your name: ");

            Name = Console.ReadLine();
        }

        public void EmailTake()
        {
            Console.WriteLine("Please write in your email address: ");

            Email = Console.ReadLine();
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

    public static DateTime Today { get; }

    public class Customer()
    {
        public string customerName { get; set; } = string.Empty;

        public string emailAddress { get; set; } = string.Empty;

        public void setCustomerNameAndEmail(string name = "", string email = "")
        {
            customerName = name;

            emailAddress = email;
        }
    }

    public class Order
    {
        public string dateOfPlacement { get; set; } = string.Empty;

        public double paymentAmount { get; set; }

        public void setDateOfPlacement(string input = "")
        {
            dateOfPlacement = input;
        }
    }

    private static void Main(string[] args)
    {
        int newVar = 0;

        DateTime thisDay = DateTime.Today;

        var newName = new NameSpeller();

        var newCustomer = new Customer();

        var newOrder = new Order();

        List<int> newArray = new List<int>();

        List<string> nameArray = new List<string>();

        Console.WriteLine("Hello, World!");

        Console.WriteLine("Welcome to the name speller.");

        newName.NameTake();

        newName.NameSpell();

        Console.WriteLine("The name that you just typed in is: " + newName.Name);

        newName.EmailTake();

        Console.WriteLine("The email address you just typed in is: " + newName.Email);

        newCustomer.setCustomerNameAndEmail(newName.Name, newName.Email);

        newOrder.setDateOfPlacement(thisDay.ToString("d"));

        Console.WriteLine("The date of placement is: " + newOrder.dateOfPlacement);
    }
}

