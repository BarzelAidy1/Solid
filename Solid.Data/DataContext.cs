using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext
    {
        public List<User> Users { get; set; }

        public DataContext()
        {
            Users = new List<User>();
            Users.Add(new User { Id=1, Name="my name"});

        }
    }
}
