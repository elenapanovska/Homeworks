using System;
using System.Collections.Generic;
using System.Text;

namespace Class05.HM.Task02.Classes
{
    public class Driver
    {
        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }
        public Driver()
        {

        }
        public string Name { get; set; }
        public int Skill { get; set; }
    }
}
