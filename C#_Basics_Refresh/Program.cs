internal class Program
{
    private static void Main(string[] args)
    {
        int newVar = 0;

        List<int> newArray = new List<int>();

        List<string> nameArray = new List<string>();

        Console.WriteLine("Hello, World!");

        Console.WriteLine("Please input a number in order to start: ");

        newVar = int.Parse(Console.ReadLine());

        if(newVar != null)
        {
            for (int i = 0; i < newVar; i++)
            {
                Console.WriteLine("Digite la letra " + (i + 1) + " de su nombre: ");

                newArray.Add(i);

                nameArray.Add(Console.ReadLine());

                if(i == newVar - 1)
                {
                    for(int j = 0; j < newVar; j++)
                    {
                        Console.WriteLine(nameArray[j]);
                    }
                }
            }
        }
    }
}

