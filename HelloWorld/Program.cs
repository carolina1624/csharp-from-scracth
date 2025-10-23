namespace HelloWorld
{
    class Program
    {
        public string Name = "Mateo";

        static void Main()
        {
            Program person = new Program();
            Console.WriteLine($"Hello World {person.Name}");
        }
    }
}


