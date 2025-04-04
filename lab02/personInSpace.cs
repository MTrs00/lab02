using lab02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class personInSpace
    {
        public int Id { get; set; }
        public required string name { get; set; }
        public required string craft { get; set; }
        public int peopleInSpaceId { get; set; }
        public peopleInSpace? peopleInSpace { get; set; }
    }

}
