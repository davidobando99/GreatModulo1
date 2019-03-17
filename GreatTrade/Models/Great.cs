using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Great
	{
      
        public List<User> users { get; set; }
        public List<Transaction> transactions { get; set; }


       public Great()
        {
            agregar();
        }
        public void agregar()
        {
            //P= PHOTOS
            //R = RELATED CITIES
            //PR = PRODUCT
            //Q = QUESTION


            //david

            User david = null;
            User laura = null;
            String[] davidP = { "carro1.jpg", "carro2.jpg" };
            List<String> davidR = new List<String>();
            davidR.Add("Medellin");
            davidR.Add( "Buenos Aires" );
            
           
            List<Question> davidQ = new List<Question>();
            Question davidQ1 = new Question(123, "Como empezar esto", "lol", laura, 1);
            davidQ.Add(davidQ1);

            List<Product> davidPRS = new List<Product>();
            Product davidPR1 = new Product(192, DateTime.Now, null, 22, 11, 20000, "CARRO CRACK",
               "el mejor carro, compralo ya", 2, 22, "Buenos Aires", davidP, davidR,davidQ);

            Product davidPR2 = new Product(193, DateTime.Now, null, 22, 11, 10000, "PC CRACK",
              "el mejor PC, compralo ya", 2, 22, "Buenos Aires", davidP, davidR, davidQ);
            davidPRS.Add(davidPR1);
            davidPRS.Add(davidPR2);
            david = new User(100012, 1, "Argentina", "David Obando", "daoban@gmail.com", "Est. Icesis, el mejor",
                "david.jpg", true, 100000, davidPRS);


            //laura
            String[] lauraP = { "carro1.jpg", "carro2.jpg" };
            List<String> lauraR = new List<String>();
            lauraR.Add("Medellin");
            lauraR.Add("Cali");
            

            List<Question> lauraQ = new List<Question>();
            Question lauraQ1 = new Question(123, "Ya per integrador?", "nonas", david, 1);
            lauraQ.Add(lauraQ1);

            List<Product> lauraPRS = new List<Product>();
            Product lauraPR1 = new Product(194, DateTime.Now, null,22, 10, 20000, "CARRO CRACK",
               "el mejor carro, compralo ya", 2, 22, "Medellin", lauraP, lauraR, lauraQ);

            Product lauraPR2 = new Product(195, DateTime.Now, null, 22, 10, 10000, "PC CRACK",
              "el mejor PC, compralo ya", 2, 22, "Medellin", lauraP, lauraR, lauraQ);
            lauraPRS.Add(lauraPR1);
            lauraPRS.Add(lauraPR2);

            laura = new User(100013, 1, "Colombia", "Laura Rubio", "lauuu@gmail.com", "Est. Icesis, la mejor en ingeco",
               "laura.jpg", true, 200000, lauraPRS);

            users.Add(david);
            users.Add(laura);
           
        }

        public void filtar()
        {

        }

        
    }
}
