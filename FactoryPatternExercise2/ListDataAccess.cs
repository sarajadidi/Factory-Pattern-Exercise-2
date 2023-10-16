using System;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public ListDataAccess()
		{
		}

        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "Guitar", Price = 350},
            new Product (){Name = "Violin", Price = 400},
            new Product (){Name = "Drumset", Price = 600}

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List database.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the List database");
        }
    }
}

