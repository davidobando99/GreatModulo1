using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
	public class Question
	{
		public const int ACTIVE = 1;
		public const int EXPIRED = 2;
		public const int ANSWERED = 3;

        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public User questioner { get; set; }
        public int status { get; set; }

        public Question(int id, string question, string answer, User questioner, int status)
        {
            this.id = id;
            this.question = question;
            this.answer = answer;
            this.questioner = questioner;
            this.status = status;
        }
    }
}
