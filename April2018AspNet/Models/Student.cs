using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace April2018AspNet.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }

        public string GetName()
        {
            return Name;
        }
    }
}
