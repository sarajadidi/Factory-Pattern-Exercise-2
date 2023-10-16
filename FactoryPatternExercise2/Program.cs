namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use:\nSQL \nList \nMongo");

            var userInput = Console.ReadLine();

            IDataAccess db =  DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach(var item in products)
            {
                Console.WriteLine($"Name: {item.Name} Price:{item.Price}");
            }
        }
    }
}
