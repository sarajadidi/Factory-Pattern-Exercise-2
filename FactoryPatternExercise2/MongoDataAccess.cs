using System;

namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
		public MongoDataAccess()
		{
		}

        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "Chihuahua", Price = 100},
            new Product (){Name = "Beagle", Price = 150},
            new Product (){Name = "Great Dane", Price = 700}

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo database.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the Mongo database");
        }
    }
}

