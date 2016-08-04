using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridaBhatta.Bll.Model
{
  public class AdultPersonModel
    {
      public int Id { get; set; }
       public string FirstName{get; set;}
       public string LastName{get; set;}
       public DateTime DOB{get; set;}
       public int Age{get; set;}
       public decimal Amount{get; set;}
       public string Address{get; set;}
       public string Street {get; set;}
    }
}
