using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_MediatorPattern
{
    public class Decor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decor(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
