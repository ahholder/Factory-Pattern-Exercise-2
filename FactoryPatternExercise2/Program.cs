namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var command = ""; bool cont = false; bool finished = false;
            List<Product> consoles = new List<Product>();
            IDataAccess item = new ListDataAccess();
            while (finished == false)
            {
                while (cont == false)
                {
                    Console.Write("Type a Database to Use (List / SQL / Mongo): ");
                    command = Console.ReadLine().ToLower();
                    if (command == "list" || command == "sql" || command == "mongo")
                    {
                        item = DataAccessFactory.GetDataAccessType(command);
                        cont = true;
                    }
                }
                foreach (var part in item.LoadData()) consoles.Add(part);
                item.SaveData();
                Console.WriteLine("Type NEXT to continue or anything else to end this exercise.");
                if (Console.ReadLine().ToLower() == "next")
                {
                    finished = false;
                    cont = false;
                } else
                {
                    finished = true;
                }
            }

        }
    }
}
