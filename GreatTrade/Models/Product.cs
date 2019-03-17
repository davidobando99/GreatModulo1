using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Product
	{
		public const int FINISHED = 1;
		public const int UNAVAILABLE = 2;
		public const int ACTIVE = 3;

        public int id { get; set; }
        public DateTime date { get; set; }
        public List<string> tags { get; set; }
        public int subCategories { get; set; }
        public int category { get; set; }
        public double price { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public int status { get; set; }
        public int units { get; set; }
        public string city { get; set; }
        public string[] photos { get; set; }
        public List<string> relatedCities { get; set; }

        public List<Question> questions { get; set; }

        public Product(int id, DateTime date, List<string> tags, int subCategories, int category, double price, string title, string description, 
            int status, int units, string city, string[] photos, List<string> relatedCities, List<Question> questions)
        {
            this.id = id;
            this.date = date;
            this.tags = tags;
            this.subCategories = subCategories;
            this.category = category;
            this.price = price;
            this.title = title;
            this.description = description;
            this.status = status;
            this.units = units;
            this.city = city;
            this.photos = photos;
            this.relatedCities = relatedCities;
            this.questions = questions;
        }
    }
}
