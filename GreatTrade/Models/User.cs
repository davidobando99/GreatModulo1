using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class User
	{
		public const int NORMAL_USER = 1;
		public const int ADMIN_USER = 2;
        public int id { get; set; }
        public int rol { get; set; }

        public string country { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string description { get; set; }
        public string photo { get; set; }
        public bool active { get; set; }
        public int currency { get; set; }

        public List<Product> productsOnSale { get; set; }

        public User(int id, int rol, string country, string name, string email, 
            string description, string photo, bool active, int currency, List<Product> productsOnSale)
        {
            this.id = id;
            this.rol = rol;
            this.country = country;
            this.name = name;
            this.email = email;
            this.description = description;
            this.photo = photo;
            this.active = active;
            this.currency = currency;
            this.productsOnSale = productsOnSale;
        }
    }
}
