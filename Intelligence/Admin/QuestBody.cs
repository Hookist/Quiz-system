using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelligence.Admin {
   public class QuestBody {
       public string NameQuest;
       public int Rating;
       public int CountAnswer;
       public string[] TextAnswer;
       public bool[] IsTrueAnswer;
      public  QuestBody(string nameQuest, int rating, int countAnswer, string[] textAnswer, bool[] isTrueAnswer) {
            NameQuest = nameQuest;
            Rating = rating;
            CountAnswer = countAnswer;
            TextAnswer = textAnswer;
            IsTrueAnswer = isTrueAnswer;
        }
    }
}
