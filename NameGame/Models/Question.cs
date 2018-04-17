using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameGame.Models
{
    public class Question
    {
        public Profile[] DisplayedProfiles { get; set; }
        public Profile correctProfile { get; set; }
        public int CorrectIndex { get; set; }
    }
}
