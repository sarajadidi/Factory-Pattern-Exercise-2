using System;

namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public SQLDataAccess()
		{
		}

        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "Barbie", Price = 100},
            new Product (){Name = "Basketball", Price = 50},
            new Product (){Name = "Americangirl Doll", Price = 200}

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL database.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the SQL database");
        }
    }
}

