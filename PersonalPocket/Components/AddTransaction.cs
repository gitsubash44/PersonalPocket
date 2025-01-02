using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPocket.Components
{
    public class AddTransaction
    {
       public string Title { get; set; }
       public string Type { get; set; }
       public decimal Amount { get; set; }
       public DateTime Date { get; set; }
       public string Tags { get; set; }
       public string Notes { get; set; }
        
    }
}
