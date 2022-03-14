using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WwwFinal.Models
{
    public class MarkPagesModel
    {
        public int markID { get; set; }
        public float mark { get; set; }
        public int examID { get; set; }
        public int studentID { get; set; }
    }
}
