using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WwwFinal.Models
{
    public class QuestionPagesModel
    {
        public QuestionPagesModel() { }
        public QuestionPagesModel(int q, string qu, string c, string r1, string r2, string r3, int i)
        {
            questionID = q;
            question = qu;
            Canswer = c;
            Ranswer01 = r1;
            Ranswer02 = r2;
            Ranswer03 = r3;
            index = i;
        }

        public int questionID { get; set; }
        public string question { get; set; }
        public string Canswer { get; set; }
        public string Ranswer01 { get; set; }
        public string Ranswer02 { get; set; }
        public string Ranswer03 { get; set; }
        public int index { get; set; }
    }
}
