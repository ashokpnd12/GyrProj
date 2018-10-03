using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyrProj.Models
{
    public class EmpMaster
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Education { get; set; }
        public int? age { get; set; }
        public string technical_exp {get;set;}
        public string Last_co_worked { get; set; }
    }
}
