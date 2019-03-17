using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Transaction
	{
		public int id { get; set; }
        public int idSeller { get; set; }
        public int idBuyer { get; set; }
        public int idProduct { get; set; }


        public User buyer { get; set; }
        public User seller { get; set; }
        public Product product { get; set; }

        public Transaction(int id, int idSeller, int idBuyer, int idProduct, User buyer, User seller, Product product)
        {
            this.id = id;
            this.idSeller = idSeller;
            this.idBuyer = idBuyer;
            this.idProduct = idProduct;
            this.buyer = buyer;
            this.seller = seller;
            this.product = product;
        }
    }
}
