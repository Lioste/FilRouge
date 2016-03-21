using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class Client
    {
            public int IDClient { get; set; }
            public string NomClient { get; set; }
            public decimal CoefClient { get; set; }
            public int IDContactClient { get; set; }
        
    }
}
