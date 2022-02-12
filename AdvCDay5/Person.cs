using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCDay5 {
    public class Person {
        public string Name { get; set; }
        public int Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public Gender gender { get; set; }
        public Hoppy hoppy { get; set; }
        

    }
    public enum Gender {
        Male,
        Female
    }
    [Flags]
    public enum Hoppy {
        Swimming,
        Football,
        Tennis
    }
}
