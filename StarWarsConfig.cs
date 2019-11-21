using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan
{
    public class StarWarsConfig
    {
        public Database Database { get; set; }
    }
    public class Database
    {
        public string ConnectionString { get; set; }

    }
    
}
