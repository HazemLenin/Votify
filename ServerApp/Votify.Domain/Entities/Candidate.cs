using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Votify.Domain.Common;

namespace Votify.Domain.Entities
{
    public class Candidate : BaseEntity
    {
        public string Name { get; set; }

        public string PollId { get; set; }
        public Poll Poll { get; set; }
        public List<Vote> Votes { get; set; }
    }
}
