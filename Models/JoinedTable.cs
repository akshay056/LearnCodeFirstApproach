using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCodeFirstApproach.Models
{
    public partial class JoinedTable
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int  Order_Id{ get; set; }
            public DateTime OrderDate { get; set; }
            public int OrderAmt { get; set; }
           
    }
}
