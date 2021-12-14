using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampCirriculum
{
    class Topic
    {
        public int Id { get; set; }    
        public int NextId { get; set; } = 13;
        public string Name { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }

        public void Print()
        { Console.WriteLine($" {Id} | {Name} |{Category} | {Difficulty}"); }


        public Topic()
        { this.Id = NextId;
            NextId = NextId + 17;
        }


    }  

}
