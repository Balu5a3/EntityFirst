using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstEntity
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Class2
    {
        public int Id { get; set; }
        public List<Class1> Class1 { get; set; }

    }
}
