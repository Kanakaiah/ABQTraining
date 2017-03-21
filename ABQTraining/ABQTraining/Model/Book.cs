using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABQTraining.Model
{
    public class Book
    {
        public string Name { get; set; }
        public List<Chapter> Chapter { get; set; }
    }
}
